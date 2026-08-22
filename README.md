# 🗄️ C# Multi-Database Entegrasyonu (MongoDB & PostgreSQL)

Bu proje, C# ile hem geleneksel ilişkisel (SQL) hem de ilişkisel olmayan (NoSQL) veritabanı mimarileri üzerine geliştirilmiş kapsamlı bir veri erişim uygulamasıdır. Proje kapsamında, modern backend sistemlerinde sıklıkla karşılaşılan "farklı veri tipleri için farklı veritabanları" (Polyglot Persistence) yaklaşımı simüle edilmiştir.

## 🚀 Proje Amacı

Aynı altyapı üzerinde birbirinden tamamen farklı iki veritabanı teknolojisinin nasıl entegre edilebileceğini kavramak. Uygulama içerisinde:

* **MongoDB** ile esnek döküman (JSON/BSON) tabanlı NoSQL mimarisi kullanılarak,
* **PostgreSQL** ile katı, kurumsal ve ilişkisel tablo (SQL) mimarisi kullanılarak temel CRUD (Ekle, Sil, Güncelle, Listele) operasyonları başarılı bir şekilde gerçekleştirilmiştir.

## 🛠️ Teknoloji Yığını

* **Programlama Dili:** C# (.NET)
* **Veritabanları:**
  * MongoDB (Community Server & Compass)
  * PostgreSQL (EnterpriseDB & pgAdmin 4)
* **Araç / Sürücüler:** MongoDB.Driver, Npgsql
* **Arayüz:** Windows Forms
