using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();

            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName},
                {"CustomerSurname", customer.CustomerSurname },
                {"CustomerCity",customer.CustomerCity },
                {"CustomerBalance",customer.CustomerBalance},
                {"CustomerShoppingCount",customer.CustomerShoppingCount}
            };

            customerCollection.InsertOne(document); 
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach(var c in customers)
            {
                customerList.Add(new Customer
                {

                    CustomerId = c["_id"].ToString(),
                    CustomerBalance =decimal.Parse( c["CustomerBalance"].ToString()),
                    CustomerCity = c["CustomerCity"].ToString(),
                    CustomerName = c["CustomerName"].ToString(),
                    CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString()),
                    CustomerSurname = c["CustomerSurname"].ToString()
                });
            }
            return customerList;
        }
    }
}
