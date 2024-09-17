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
