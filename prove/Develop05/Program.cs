using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalmanager = new GoalManager();
        GoalFileManager fileManager = new GoalFileManager("test.txt");
        Menu menu = new Menu();
        menu.menuLogic(goalmanager, fileManager);
    }
}