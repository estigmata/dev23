sqlcmd -S trainingws -i .\1.insert-categories.sql;
sqlcmd -S trainingws -i .\2.insert-users.sql;
sqlcmd -S trainingws -i .\3.insert-banners.sql;
sqlcmd -S trainingws -i .\4.insert-contacts.sql;
sqlcmd -S trainingws -i .\5.insert-images.sql;
sqlcmd -S trainingws -i .\6.insert-promoters.sql;
sqlcmd -S trainingws -i .\7.insert-benefits.sql;
sqlcmd -S trainingws -i .\8.insert-templates.sql;
sqlcmd -S trainingws -i .\9.insert-tags.sql;
sqlcmd -S trainingws -i .\10.insert-promoterTag.sql;
sqlcmd -S trainingws -i .\11.insert-stores.sql;