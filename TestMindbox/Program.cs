using TestMindbox;

Circle c1 = new Circle(2, 1, 3, "Circle-0");
Circle c2 = new Circle(3.5, 2, 4, "Circle-1");
Triangle t1 = new Triangle(5, 3, 4, 2, 1, "Triangle-0");

Console.WriteLine(c1.area());
Console.WriteLine(t1.area());

// SELECT NameProduct, NameCategory
// FROM Products FULL JOIN Categories
// ON Products.ProductId = Categories.CategoryId