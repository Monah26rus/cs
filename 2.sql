WITH ProductCategoryCTE AS (
    SELECT P.ProductName, ISNULL(C.CategoryName, 'Без категории') AS CategoryName
    FROM Products P
    LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
    LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID
)

SELECT * FROM ProductCategoryCTE;
