# Entity FrameWork Code First Database Migration Tool 

Entity Framework Code First tablo class'ları üzerinde yapılan değişiklikleri hızlı bir şekilde veri tabanına uygulanmasını sağlayan araç.

Araç çalıştırıldığında classlar üzerinde bir değişiklik yapılmışsa bunu algılar ve veri tabanının güncellenmesi gerektiğini bildirir. Değişiklikleri veritabanına uygulamadan önce "Script" butonu ile aracın veri tabanında yapacağı değişiklikleri SQL sorgusu şekline görebilir, detaylı bilgil elde edebilirsiniz. 

Değişikliklerin veritabanına uygulanması.
```csharp
var initializer = new MigrateDatabaseToLatestVersion<EFCodeFirstContext, EFCodeFirst.Data.Migrations.Configuration>();
initializer.InitializeDatabase(db);
```

Yapılacak değişikliklerin SQL sorgusu ile gösterilmesi.
```csharp
var migrator = new DbMigrator(new EFCodeFirst.Data.Migrations.Configuration());
var script = new MigratorScriptingDecorator(migrator);
```