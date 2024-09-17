# Задача на C#
*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

*- Юнит-тесты*

*- Легкость добавления других фигур*

*- Вычисление площади фигуры без знания типа фигуры*

*- Проверку на то, является ли треугольник прямоугольным*

#### Решение задачи:
- Базовый абстрактный класс ["Фигура"](https://github.com/BerezkaVika/Mindbox_Test_Task/blob/main/LibraryFigures/LibraryFigures/Figure.cs)
- Наследуемый класс ["Треуголиник"](https://github.com/BerezkaVika/Mindbox_Test_Task/blob/main/LibraryFigures/LibraryFigures/Triangle.cs)
- Наследуемый класс ["Круг"](https://github.com/BerezkaVika/Mindbox_Test_Task/blob/main/LibraryFigures/LibraryFigures/Circle.cs)
- Класс для добавления [других фигур](https://github.com/BerezkaVika/Mindbox_Test_Task/blob/main/LibraryFigures/LibraryFigures/FigurePrototype.cs)
- [Юнит тесты](https://github.com/BerezkaVika/Mindbox_Test_Task/blob/main/LibraryFigures/UnitTestProject1/UnitTest1.cs)

  # Задача на SQL
  
*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*

### Код создания БД
```
USE [Магазин]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Категория](
  [Код_категории] [int] IDENTITY(1,1) NOT NULL,
  [Имя_категории] [nvarchar](50) NOT NULL,
  [Описание] [nvarchar](50) NULL,
 CONSTRAINT [PK_Категория] PRIMARY KEY CLUSTERED 
(
  [Код_категории] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продукт](
  [Код_продукта] [int] IDENTITY(1,1) NOT NULL,
  [Имя_продукта] [nvarchar](50) NOT NULL,
  [Цена] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Продукт] PRIMARY KEY CLUSTERED 
(
  [Код_продукта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продукт_Категория](
  [Код_продукта] [int] NOT NULL,
  [Код_категории] [int] NOT NULL,
 CONSTRAINT [PK_Продукт_Категория] PRIMARY KEY CLUSTERED 
(
  [Код_продукта] ASC,
  [Код_категории] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Продукт_Категория]  WITH CHECK ADD  CONSTRAINT [FK_Продукт_Категория_Категория] FOREIGN KEY([Код_категории])
REFERENCES [dbo].[Категория] ([Код_категории])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Продукт_Категория] CHECK CONSTRAINT [FK_Продукт_Категория_Категория]
GO
ALTER TABLE [dbo].[Продукт_Категория]  WITH CHECK ADD  CONSTRAINT [FK_Продукт_Категория_Продукт] FOREIGN KEY([Код_продукта])
REFERENCES [dbo].[Продукт] ([Код_продукта])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Продукт_Категория] CHECK CONSTRAINT [FK_Продукт_Категория_Продукт]
GO
```
