USE dbo;

--USERS
GO
CREATE TRIGGER trg_UpdateManager
ON dbo.managers
AFTER UPDATE
AS
    UPDATE dbo.managers
    SET update_time = GETDATE()
    WHERE id IN (SELECT DISTINCT id FROM Inserted)


-- CATEGORIES
GO
CREATE TRIGGER trg_UpdateCategory
ON dbo.categories
AFTER UPDATE
AS
    UPDATE dbo.categories
    SET update_time = GETDATE()
    WHERE id IN (SELECT DISTINCT id FROM Inserted)


-- PRODUCTS
GO
CREATE TRIGGER trg_UpdateProduct
ON dbo.products
AFTER UPDATE
AS
    UPDATE dbo.products
    SET update_time = GETDATE()
    WHERE id IN (SELECT DISTINCT id FROM Inserted)

--ORDERS_LOG
GO
CREATE TRIGGER trg_UpdateOrder
ON dbo.orders
AFTER UPDATE
AS
    UPDATE dbo.orders
    SET update_time = GETDATE()
    WHERE id IN (SELECT DISTINCT id FROM Inserted)


--COMMENTS
GO
CREATE TRIGGER trg_UpdateInvoice
ON dbo.invoices
AFTER UPDATE
AS
    UPDATE dbo.invoices
    SET update_time = GETDATE()
    WHERE id IN (SELECT DISTINCT id FROM Inserted)