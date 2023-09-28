/*
Так как у нас связь Many To Many (M2M), у нас 3 исходных таблицы:
Product - таблица с конкретными продуктами, их Id, названия, уникальный хар-ки и т.п.
Category - таблица с категориями, их Id, названия, др. свойства присущие этой категории.
ProductCategory - таблица для связи M2M, так мы присваиваем продуктам категории.

Теперь выберем все комбинации [название продукта] [название категории] и выведем продукты, которым не присвоена категория
*/

SELECT p.Name, c.Name
FROM Product as p
FULL JOIN ProductCategory as pc
ON p.ProductId = pc.ProductId
FULL JOIN Category AS c
ON pc.CategoryId = c.CategoryId