# Entity FrameWork Code First Database Migration Tool 

Entity Framework Code First tablo class'ları üzerinde yapılan değişiklikleri hızlı bir şekilde veri tabanına uygulanmasını sağlayan araç.

Araç çalıştırıldığında classlar üzerinde bir değişiklik yapılmışsa bunu algılar ve veri tabanının güncellenmesi gerektiğini bildirir. Değişiklikleri veritabanına uygulamadan önce "Script" butonu ile aracın veri tabanında yapacağı değişiklikleri SQL sorgusu şekline görebilir, detaylı bilgil elde edebilirsiniz. 

```code
Migration aracının çalışabilmesi için "nuget package manager console" üzerinden "enable-migrations" komutu çalıştırılmış olmalı. Çalıştırılan bu komut ile oluşturulan "Configuration" sınıfı içerisine otomatik migration işlemi için AutomaticMigrationDataLossAllowed = true; satırı Configuration sınıfının "constructor" metodu içerisine eklenmeli.
```
