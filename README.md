# Mvc Proje Kampı

Bu proje geliştirilirken Ekşi Sözlük vb. bir internet sitesini göz önüne alarak geliştirme yaptım. Yazarlar kendilerine özel geliştirilmiş panel üzerinden yeni başlıklar açabiliyor,
 başlıklara içerikler yazabiliyor, diğer kullanıcılarla mesajlaşabiliyor; adminler kendilerine özel geliştirilmiş panel aracılığıyla site arayüzünden gönderilen iletişim mesajlarını okuyabiliyor,
 yeni başlıklar oluşturabiliyor, yetkilendirme işlemlerini yapabiliyor, sistemdeki görselleri galeri aracılığıyla görebiliyor ve tabloları "CSV, Excel veya PDF" şeklinde export edebiliyorlar.
 Sistem 2 ana panel üzerine kurulmuştur: Yazar Paneli ve Admin Paneli.
## Yazar Paneli

Yazarlar/Kullanıcılar sisteme üye olarak Yazar Paneli'ne giriş yapabiliyorlar. Şifreleri Hashleme algoritmaları aracılığıyla veritabanında hashlenerek tutuluyor.
Yazarlar bu panel aracılığıyla aşağıdaki işlemleri gerçekleştirebiliyorlar:

- Profilim sayfasında kişisel bilgilerini güncelleyebiliyor.
- Başlıklarım sayfasında kendi oluşturduğu başlıkları görüntüleyebiliyor.
- Tüm Başlıklar sayfasında sistemdeki tüm başlıkları görüp istediği başlığı seçerek ilgili başlığa içerik yazabiliyor.
- Mesajlar sayfasında kendisine gelen mesajlar ve kendisinin gönderdiği mesajları görebiliyor.
- Yazılarım sayfasında kendi yazdığı içerikleri ve içeriklerin ait olduğu başlık bilgisini tarih/zaman bilgileriyle beraber görüntüleyebiliyor.
## Admin Paneli

Admin sisteme üye olarak kendisine atanan Rol yetkileri dahilinde Admin Paneli'ne giriş yapabilir. Burada da şifre bilgileri hashlenerek veritabanınıda tutulur. Adminler bu panel aracılığıyla aşağıdaki
işlemleri gerçekleştirebilirler:
- Kategoriler sayfasından kategori ekleme/silme/güncelleme/listeleme ve listeyi export etme işlemlerini yapabilirler.
- Yazarlar sayfasında sistemdeki yazarların listesini ve bilgilerine erişebilirler.
- Başlıklar sayfasında sistemdeki başlıkları listeleme/güncelleme/ekleme/silme işlemlerini gerçekleştirebilirler.
- İletişim & Mesajlar sayfasından ise kendilerine direkt olarak gelen mesajları ve kendilerinin diğer kullanıcılara gönderdikleri direkt mesajlara ek olarak sitenin son kullanıcı arayüzündeki iletişim formuna
 yazılan mesajları da görüntüleyebilmektedir.
- Galeri sayfası aracılığıyla sistemdeki görselleri görüntüleyebilmektedir.
- Grafik sayfası aracılığıyla da Google Chart ile oluşturduğum Pie grafiğini görebilmektedir.
- Yetkilendirmeler sayfası aracılığıyla sisteme yeni admin ekleyebilir, adminlerin yetkilerini değiştirebilir veya yetkilerini pasifleştirebilirler.
## Proje Özellikleri

- Asp.Net Mvc5 ile geliştirildi.
- Veritabanı olarak MSSQL tercih edildi.
- N Katmanlı Mimari kapsamında (BusinessLayer, DataAccessLayer, EntityLayer, PresentationLayer) geliştirildi.
- SOLID prensiplerine olabildiğince bağlı kalınmaya çalışıldı.
- Fluent Validation kullanıldı.
- Entity Framework ile Code First yaklaşımıyla geliştirildi.
- Çeşitli scriptler (örneğin, datagrid) kullanıldı.
- Oturum yönetimi Session ile gerçekleştirildi. Güvenlik için Authorize ve Authentication'lar kullanıldı.
- Google Charts ve Sweet Alert kullanıldı.
- Özel hata sayfaları (404) oluşturuldu.

  
## Kullanılan Teknolojiler

- Code First / EntityFramework
- Authentication / Authorize / Fluent Validation
- MSSQL
- LINQ Sorguları
- Partial Views
- Sweet Alert / Google Chart
- DataTable / Pagination / Searching
- Custom Error Pages
## Ekran Görüntüleri
![Ekran görüntüsü 2025-01-09 180434](https://github.com/user-attachments/assets/11a7fe82-e1d7-4d1b-9b36-c3616f830b7e)
![screencapture-localhost-44302-Login-Index-2025-01-09-17_58_13](https://github.com/user-attachments/assets/951c9374-e97e-448c-90a4-de21d02f3e66)
![screencapture-localhost-44302-AdminCategory-2025-01-09-17_59_36](https://github.com/user-attachments/assets/4d3c70b3-997e-4e6c-8e7c-c09c6f92fc7f)
![screencapture-localhost-44302-Heading-Index-2025-01-09-17_59_54](https://github.com/user-attachments/assets/2c1d014a-90cf-435d-b1aa-4139c39b7705)
![screencapture-localhost-44302-Content-ContentByHeading-1-2025-01-09-18_00_17](https://github.com/user-attachments/assets/0e7f8e7a-6b22-44ae-b463-1f0ba247d2dd)
![screencapture-localhost-44302-Writer-Index-2025-01-09-18_00_49](https://github.com/user-attachments/assets/c0032a9a-ae44-480e-b4ea-4039e1ccd4ff)
![screencapture-localhost-44302-Chart-Index-2025-01-09-18_01_03](https://github.com/user-attachments/assets/d37227ae-267b-4b05-8574-6c58d0a0efff)
![screencapture-localhost-44302-About-Index-2025-01-09-18_01_18](https://github.com/user-attachments/assets/f0474130-7ef9-41ae-ae1e-53bec57f7dce)
![screencapture-localhost-44302-About-Index-2025-01-09-18_01_26](https://github.com/user-attachments/assets/a996e8ca-d86b-4a22-b07e-47b6381bc437)
![screencapture-localhost-44302-Heading-HeadingReport-2025-01-09-18_01_47](https://github.com/user-attachments/assets/83f26d08-e5a2-463d-9e66-d08fc7f27d5b)
![screencapture-localhost-44302-Contact-Index-2025-01-09-18_02_01](https://github.com/user-attachments/assets/97a1e55a-9089-4c13-aef3-3e063ee69fa5)
![screencapture-localhost-44302-Authorization-Index-2025-01-09-18_02_30](https://github.com/user-attachments/assets/d2eb3f32-0a7c-4b7f-804d-1a5ce717af70)
![screencapture-localhost-44302-Authorization-AddAdmin-2025-01-09-18_02_43](https://github.com/user-attachments/assets/fecefe13-9c57-4c2a-bfd2-9551d5f83096)
![screencapture-localhost-44302-Gallery-Index-2025-01-09-18_02_57](https://github.com/user-attachments/assets/ee75f9a6-78c2-43b0-a9d7-a557eccd43d8)
![screencapture-localhost-44302-ErrorPage-Page404-2025-01-09-18_03_05](https://github.com/user-attachments/assets/e01b9b7a-f9a6-4a48-944f-5bce6dbaf576)
![screencapture-localhost-44302-Login-WriterLogin-2025-01-09-18_08_43](https://github.com/user-attachments/assets/21c5d42d-2c36-42de-8050-d91f617384e0)
![screencapture-localhost-44302-WriterPanel-WriterProfile-2025-01-09-18_09_42](https://github.com/user-attachments/assets/bf0dfed9-2d53-4fd6-b228-12cecc086d2a)
![screencapture-localhost-44302-WriterPanel-MyHeading-2025-01-09-18_09_49](https://github.com/user-attachments/assets/5a88e07c-013c-4a98-9c1c-b214c371d263)
![screencapture-localhost-44302-WriterPanel-AllHeading-2025-01-09-18_09_57](https://github.com/user-attachments/assets/fc562457-d221-488e-8ef6-50f0b2d3e02c)
![screencapture-localhost-44302-WriterPanelContent-MyContent-2025-01-09-18_10_08](https://github.com/user-attachments/assets/20ff266d-555d-4789-9398-76dda3cf6c26)
![screencapture-localhost-44302-WriterPanelMessage-InBox-2025-01-09-18_10_22](https://github.com/user-attachments/assets/f53bf391-6e24-43ae-bb02-e885f46dcb05)
![screencapture-localhost-44302-WriterPanelMessage-Sendbox-2025-01-09-18_10_33](https://github.com/user-attachments/assets/c29fe28d-7d48-452d-a620-53d7f22c6e22)
![screencapture-localhost-44302-WriterPanelMessage-NewMessage-2025-01-09-18_10_40](https://github.com/user-attachments/assets/079d905e-4a50-4b20-a12e-81c9a7e20859)
![Ekran görüntüsü 2025-01-09 181336](https://github.com/user-attachments/assets/db3918d1-8f0f-424f-8782-38b5dae92238)
![Ekran görüntüsü 2025-01-09 181418](https://github.com/user-attachments/assets/f7fd48c8-c2d2-4b74-aa85-d13abaf6e731)
![Ekran görüntüsü 2025-01-09 181438](https://github.com/user-attachments/assets/454cb878-ef02-4fde-b375-00c60e8cc896)
![Ekran görüntüsü 2025-01-09 181456](https://github.com/user-attachments/assets/f3e8d203-102e-4d37-b8b9-b5888aff0ba5)
![Ekran görüntüsü 2025-01-09 181514](https://github.com/user-attachments/assets/90b30a63-996d-4c3c-9b8f-47f8dc2594fc)
