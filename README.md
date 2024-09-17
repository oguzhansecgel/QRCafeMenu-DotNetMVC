# QR Menü Projesi API Dökümantasyonu

Backend tarafı Spring Boot ile, frontend bağlantısı .Net Core MVC ile yazıldı. Bu proje, QR kod tabanlı bir kafe menü uygulamasının backend kısmını içerir. Proje, menüler, kategoriler, yiyecekler ve iletişim bilgileri gibi kısımları yönetmeye yönelik RESTful API'ler sağlar. API uç noktaları aşağıda açıklanmıştır.

Backend kodlarına ulaşmak için : https://github.com/oguzhansecgel/QRCafeMenu-SpringBoot
##Proje Görselleri

## Hakkında Sayfası
![About Sayfası]([https://raw.githubusercontent.com/oguzhansecgel/QRCafeMenu-DotNetMVC/master/Recipe.UI/wwwroot/about.png?token=GHSAT0AAAAAACN2GM7AXBD6EXZDOFP2U4NGZXJP4FQ](https://github.com/oguzhansecgel/QRCafeMenu-DotNetMVC/blob/master/Recipe.UI/wwwroot/about.png?raw=true))

## Menü Sayfası
![Menü Sayfası]([[https://raw.githubusercontent.com/oguzhansecgel/QRCafeMenu-DotNetMVC/master/Recipe.UI/wwwroot/menu.png?token=GHSAT0AAAAAACN2GM7AZ7B72RI2QEN444TUZXJP5BA](https://github.com/oguzhansecgel/QRCafeMenu-DotNetMVC/blob/master/Recipe.UI/wwwroot/menu.png?raw=true)](https://github.com/oguzhansecgel/QRCafeMenu-DotNetMVC/blob/master/Recipe.UI/wwwroot/menu.png))



## API Uç Noktaları

### About API

| HTTP Metodu | URL                           | Açıklama                             |
|-------------|-------------------------------|--------------------------------------|
| `GET`       | `/api/about/getByIdAbout/{id}` | Belirli bir About bilgisini getirir. |
| `GET`       | `/api/about/getAllAbout`       | Tüm About kayıtlarını getirir.       |
| `DELETE`    | `/api/about/deletedAbout/{id}` | Belirli bir About kaydını siler.     |
| `POST`      | `/api/about/createdAbout`      | Yeni bir About kaydı oluşturur.      |
| `PUT`       | `/api/about/updateAbout/{id}`  | Belirli bir About kaydını günceller. |

---

### Category API

| HTTP Metodu | URL                                 | Açıklama                                 |
|-------------|-------------------------------------|------------------------------------------|
| `GET`       | `/api/category/getByIdCategory/{id}`| Belirli bir kategori bilgisini getirir.  |
| `GET`       | `/api/category/getAllCategory`      | Tüm kategorileri getirir.                |
| `DELETE`    | `/api/category/deleteCategory/{id}` | Belirli bir kategori kaydını siler.      |
| `POST`      | `/api/category/createCategory`      | Yeni bir kategori kaydı oluşturur.       |
| `PUT`       | `/api/category/updateCategory/{id}` | Belirli bir kategori kaydını günceller.  |

---

### Contact API

| HTTP Metodu | URL                               | Açıklama                                 |
|-------------|-----------------------------------|------------------------------------------|
| `GET`       | `/api/contact/getByIdContact/{id}`| Belirli bir iletişim bilgisini getirir.  |
| `GET`       | `/api/contact/getAllContact`      | Tüm iletişim bilgilerini getirir.        |
| `DELETE`    | `/api/contact/deleteContact/{id}` | Belirli bir iletişim kaydını siler.      |
| `POST`      | `/api/contact/createContact`      | Yeni bir iletişim kaydı oluşturur.       |
| `PUT`       | `/api/contact/updateContact/{id}` | Belirli bir iletişim kaydını günceller.  |

---

### Food API

| HTTP Metodu | URL                                       | Açıklama                                 |
|-------------|-------------------------------------------|------------------------------------------|
| `GET`       | `/api/food/getAllFood`                    | Tüm yiyecek kayıtlarını getirir.         |
| `GET`       | `/api/food/foodWithCategory/{categoryId}` | Belirli bir kategoriye ait yiyecekleri getirir. |
| `POST`      | `/api/food/createFood`                    | Yeni bir yiyecek kaydı oluşturur.        |

---

### Food Image API

| HTTP Metodu | URL                                         | Açıklama                                 |
|-------------|---------------------------------------------|------------------------------------------|
| `GET`       | `/api/foodImage/foodImageWithFood/{foodId}` | Belirli bir yiyeceğe ait görselleri getirir. |
| `GET`       | `/api/foodImage/getAllFoodImage`            | Tüm yiyecek görsellerini getirir.        |
| `DELETE`    | `/api/foodImage/deletedFoodImage/{id}`      | Belirli bir yiyecek görselini siler.     |
| `POST`      | `/api/foodImage/createFoodImage`            | Yeni bir yiyecek görseli yükler.         |

---

## API Kullanım Detayları

- `GET` istekleri, veritabanında bulunan kayıtları getirir.
- `POST` istekleri, veritabanına yeni kayıtlar ekler.
- `PUT` istekleri, var olan kayıtları günceller.
- `DELETE` istekleri, belirli bir kaydı siler.

## Localhost Üzerinde Çalıştırma

API'yi yerel ortamda çalıştırmak için aşağıdaki URL'leri kullanabilirsiniz:
