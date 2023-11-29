CREATE TABLE Products
(
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL
);

CREATE TABLE Categories
(
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategoryMapping (
    MappingId INT PRIMARY KEY,
    ProductId INT,
    CategoryId INT NULL,
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

-- Вставляем данные в таблицу продуктов
INSERT INTO Products (ProductName) VALUES
    ('Product1'),
    ('Product2'),
    ('Product3');

-- Вставляем данные в таблицу категорий
INSERT INTO Categories (CategoryName) VALUES
    ('Category1'),
    ('Category2');

-- Вставляем данные в таблицу маппинга продуктов и категорий
INSERT INTO ProductCategoryMapping (MappingId, ProductId, CategoryId) VALUES
    (1, 1, 1),  -- Продукт1 в Категории1
    (2, 1, 2),  -- Продукт1 в Категории2
    (3, 2, NULL), -- Продукт2 без категории
    (4, 3, 1);  -- Продукт3 в Категории1

SELECT P.ProductName, ISNULL(C.CategoryName, 'No category') AS CategoryName
FROM Products P
LEFT JOIN ProductCategoryMapping PCM ON P.ProductId = PCM.ProductId
LEFT JOIN Categories C ON PCM.CategoryId = C.CategoryId;
