-- ѕредполагаем, что продукты и категории св€заны через промежуточную таблицу
select Product.Name as ProductName, Category.Name as CategoryName
from Category
join ProductCategory
on ProductCategory.Category = Category.Id
right join Product
on Product.Id = ProductCategory.Product