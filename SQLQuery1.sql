INSERT INTO Номенкулатура ([id товара],[Тип товара],Остаток) VALUES (1,N'ashash',5)

DBCC CHECKIDENT('Номенкулатура', RESEED, 0)
