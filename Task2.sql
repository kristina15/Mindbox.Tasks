SELECT P.Name, C.Name
FROM [dbo].[Products] AS P
LEFT JOIN [dbo].[Products_Category] AS PC
ON P.Id = PC.product_id
LEFT JOIN [dbo].[Category] AS C
ON PC.category_id = C.Id