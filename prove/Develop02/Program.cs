using System;

class Program
{
    static void Main(string[] args)
    {
        ReadWrite ReadWrite1 = new ReadWrite();

        int Selection = 0;

        while (Selection != 6)
        {
        Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Delete\n6. Quit\nWhat would you like to do?");
        Selection = int.Parse(Console.ReadLine());
        if (Selection == 1)
        {
            Entry Entry1 = new Entry();
            Entry1.addEntry();
            ReadWrite1._ReadingList.Add(Entry1);
        }
        else if (Selection == 2)
        {
            ReadWrite1.Display();
        }
        else if (Selection == 3)
        {
            ReadWrite1.ReadFile();
        }
        else if (Selection == 4)
        {
            ReadWrite1.WriteFile();
        }
        else if (Selection == 5)
        {
            ReadWrite1.deleteFile();
        }
        else if (Selection != 6)
        {
            Console.WriteLine("-------\nInvalid Selection\n-------");
        }
        }
    }

}