USE dbo;

--USERS
CREATE TABLE managers (
	id			int			 PRIMARY KEY IDENTITY(1,1),
    login		NVARCHAR(32) NOT NULL UNIQUE,
	password	NVARCHAR(32) NOT NULL,
	disp_name	NVARCHAR(32) NOT NULL,
	insert_time DATETIME2 NOT NULL DEFAULT GETDATE(),
	update_time DATETIME2 NOT NULL DEFAULT GETDATE(),
)


-- CATEGORIES
CREATE TABLE categories(
	id			int				PRIMARY KEY IDENTITY(1,1),
	name		NVARCHAR(32)	NOT NULL UNIQUE,
	description TEXT,
	insert_time DATETIME2 NOT NULL DEFAULT GETDATE(),
	update_time DATETIME2 NOT NULL DEFAULT GETDATE(),
)


-- PRODUCTS
CREATE TABLE products (
	id			INT			 PRIMARY KEY IDENTITY(1,1),
	name		NVARCHAR(32) NOT NULL UNIQUE,
	category_id	INT			 NOT NULL FOREIGN KEY REFERENCES categories(id),
	insert_time DATETIME2	 NOT NULL DEFAULT GETDATE(),
	update_time DATETIME2	 NOT NULL DEFAULT GETDATE(),
)

--ORDERS_LOG
CREATE TABLE orders(
	id			INT          PRIMARY KEY IDENTITY(1,1),
	user_login	NVARCHAR(32) NOT NULL,
	product_id	INT          NOT NULL FOREIGN KEY REFERENCES products(id),
	order_status NVARCHAR(32) NOT NULL,
	insert_time DATETIME2    NOT NULL DEFAULT GETDATE(),
	update_time DATETIME2    NOT NULL DEFAULT GETDATE(),
)

--COMMENTS
CREATE TABLE invoices(
	id			  INT		   PRIMARY KEY IDENTITY(1,1),
	order_id	  INT		   NOT NULL FOREIGN KEY REFERENCES orders(id),
	manager_id	  INT		   NOT NULL FOREIGN KEY REFERENCES managers(id),
	invoice_status  NVARCHAR(32) NOT NULL,
	insert_time   DATETIME2	   NOT NULL DEFAULT GETDATE(),
	update_time   DATETIME2    NOT NULL DEFAULT GETDATE(),
)


