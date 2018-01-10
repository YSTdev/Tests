SELECT tCustomers.Name
FROM (
  SELECT DISTINCT CustomerId AS Customers
  FROM Purchases
  WHERE ProductName = 'milk' 
  AND CustomerId NOT IN (
    SELECT CustomerId
    FROM Purchases
    WHERE PurchaiseDateTime > DATEADD( MONTH,-1,GETDATE()) 
    AND ProductName = 'sourcream'
    )
  ) AS tPurchases JOIN Registrations tCustomers 
ON tPurchases.Customers = tCustomers.CustomerId
