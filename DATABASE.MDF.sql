/****** Object:  Table [dbo].[pizzas]    Script Date: 05/13/2011 09:44:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pizzas]') AND type in (N'U'))
DROP TABLE [dbo].[pizzas]
GO
/****** Object:  Table [dbo].[toppings]    Script Date: 05/13/2011 09:44:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[toppings]') AND type in (N'U'))
DROP TABLE [dbo].[toppings]
GO
/****** Object:  Table [dbo].[toppings]    Script Date: 05/13/2011 09:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[toppings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[toppings](
	[topping] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[cost] [smallmoney] NOT NULL
)
END
GO
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Cheese', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Broccoli', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Peppers', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Onions', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Olives', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Sausage', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Pepperoni', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Chicken', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Ham', 0.7500)
INSERT [dbo].[toppings] ([topping], [cost]) VALUES (N'Steak', 0.7500)
/****** Object:  Table [dbo].[pizzas]    Script Date: 05/13/2011 09:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pizzas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pizzas](
	[name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[cost] [money] NULL
)
END
GO
INSERT [dbo].[pizzas] ([name], [description], [cost]) VALUES (N'Red + White', N'Red Sauce, Cheese', 6.0000)
INSERT [dbo].[pizzas] ([name], [description], [cost]) VALUES (N'Veg-a-saur-us', N'Red Sauce, Cheese, Peppers, Onions, Olives, Broccoli', 9.0000)
INSERT [dbo].[pizzas] ([name], [description], [cost]) VALUES (N'Meat-a-saur-us', N'Red Sauce, Cheese, Sausage, Pepperoni, Chicken, Ham, Steak', 9.7500)
