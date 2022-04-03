Mult_Migr_Prov_DP_Entity

***Иногда может потребоваться использовать более одного провайдера БД (например Microsoft SQL Server и SQLite) с DbContext. В этом случае создается несколько миграций — по одному для каждого провайдера.***

***Один из способов создания нескольких наборов миграции — использование своего типа DbContext для каждого провайдера.***

***Add-Migration InitialCreate -Context BlogContext -OutputDir Migrations\SqlServerMigrations***

***Add-Migration InitialCreate -Context SqliteBlogContext -OutputDir Migrations\SqliteMigrations***
