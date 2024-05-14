SET IDENTITY_INSERT [dbo].[tblStock] ON
INSERT INTO [dbo].[tblStock] ([StockID], [StockName], [Price], [Quantity], [Available], [Description], [ArrivalDate]) VALUES (1, N'Nike Hoodie', 39.99, 24, 1, N'Comfortable Nike Hoodie', N'2024-05-10')
INSERT INTO [dbo].[tblStock] ([StockID], [StockName], [Price], [Quantity], [Available], [Description], [ArrivalDate]) VALUES (2, N'Nike Joggers', 34.99, 22, 1, N'Comfortable Nike Joggers', N'2024-05-10')
INSERT INTO [dbo].[tblStock] ([StockID], [StockName], [Price], [Quantity], [Available], [Description], [ArrivalDate]) VALUES (3, N'H&M T-shirt', 12.99, 35, 1, N'Cotton Loose fit T-shirt', N'2024-05-11')
SET IDENTITY_INSERT [dbo].[tblStock] OFF
