﻿using System;
using System.Data.SqlClient;

namespace DAL.Tests
{
   public abstract class RepositoryTestsBase : IDisposable
   {
       protected string _connectionString { get; set; }

       protected RepositoryTestsBase()
       {
           _connectionString = "Data Source=DESKTOP-VCAU3IO;Initial Catalog=dboTests;Integrated Security=True";
           using (var connection = new SqlConnection(_connectionString))
           {
               connection.Open();
               SqlCommand command = new SqlCommand(@"
               SET IDENTITY_INSERT managers ON;
               INSERT INTO managers (id, login, password, disp_name) VALUES (1, 'Manager1', '1111', 'MarKson');
               INSERT INTO managers(id, login, password, disp_name) VALUES (2, 'Manager2', '123', 'German');
               SET IDENTITY_INSERT managers OFF;
               SET IDENTITY_INSERT categories ON;
               INSERT INTO categories (id, name) VALUES (1,'Food'), (2,'Tech'), (3,'Clothes');
               SET IDENTITY_INSERT categories OFF;
               SET IDENTITY_INSERT products ON;
               INSERT INTO products (id, name, category_id) VALUES (1, 'Burger', 1), (2, 'Hotdog', 1), (3, 'Pizza', 1);
               INSERT INTO products (id, name, category_id) VALUES (4,'Laptop', 2), (5, 'Phone', 2), (6, 'Headphones', 2);
               INSERT INTO products (id, name, category_id) VALUES (7, 'Hat', 3), (8, 'Shirt', 3), (9, 'Trousers', 3);
               SET IDENTITY_INSERT products OFF;
               SET IDENTITY_INSERT orders ON;
               INSERT INTO orders (id, user_login, product_id, order_status) VALUES (1, 'User1', 1, 'Processed'), (2, 'User2', 4, 'Processed'), (3, 'User3', 7, 'Waiting');
               INSERT INTO orders (id, user_login, product_id, order_status) VALUES (4, 'User4', 2, 'Processed'), (5, 'User5', 5, 'Processed'), (6, 'User6', 8, 'Waiting');
               SET IDENTITY_INSERT orders OFF;
               SET IDENTITY_INSERT invoices ON;
               INSERT INTO invoices (id, order_id, manager_id, invoice_status) VALUES (1, 1, 1, 'Waiting'), (2, 2, 1, 'Sended');
               INSERT INTO invoices (id, order_id, manager_id, invoice_status) VALUES (3, 4, 2, 'Sended'), (4, 5, 2, 'Waiting');
               SET IDENTITY_INSERT invoices OFF;
           ", connection);
               command.ExecuteNonQuery();
           }
       }
       public void Dispose()
       {
           using (var connection = new SqlConnection(_connectionString))
           {
               connection.Open();
               SqlCommand command = new SqlCommand(@"
                   DELETE FROM invoices
                   DELETE FROM orders
                   DELETE FROM products 
                   DELETE FROM categories 
                   DELETE FROM managers
               ", connection);
               command.ExecuteNonQuery();
           }
       }
   }
}