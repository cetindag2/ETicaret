# ETicaret
 -> Mimari olarak Onion architecture kullanılmıştır.
 -> CQRS pattern ile iş katmanı özelleştirilmiştir.
 
 -> Modeller Core katmanındaki Domains klasüründe tutulmuştur.
 -> Core katmanında Repository'ler altında interface'ler aracılığı ile soyutlama yapılmıştır. Bu interface'lerin concrete'leri Infrastructure dizinindeki Persistence katmanında Repositories sınıfında oluşturulmuştur.
 -> Database iletişiminde Entityframework kullanılmıştır. Dbcontext, Infrustructure dizinindeki Persistence katmanında oluşturulmuştur
 
 -> Presentation katmanında Rest özellikli . Core Web api oluşturulmuştur. Product ve User kontrolleri hazır durumdadır. 
 -> ProductController üzerinde ürünlelerle ilgili Get, GetByID, Post, Delete, Put, Upload, GetProductImage, DeleteProductImage Endpointleri mevcuttur. Ürün bilgisi listeleme, id'ye göre sorgulama , ürün ekleme, silme, resim yükleme, ürüne bağlı resimleri gösterme, resim silme gibi işlevler mevcuttur.
 -> UserController üzerinde CreateUser ve Login endpointleri mevcuttur. Login işlevinde Microsoft identity kütüphanesi kullanılmıştır. 
