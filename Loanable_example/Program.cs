// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Book book = new Book("Maze Runner", "9781111111", 2345623);

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();
// book.ShowBookDetails();

Dvd dvd = new Dvd("Coach Carter");
dvd.Display();
dvd.CheckOut();
dvd.Display();


