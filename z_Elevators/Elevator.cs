public class Elevator
{
    bool _VIPvator = false;
    protected int floorPosition = 0;
    public Elevator(List<Floor> building)
    {
        _VIPvator = false;
        List<Floor> _building = building;

    }
    public Elevator (List<Floor> building, bool VIPvator)
    {
        _VIPvator = VIPvator;
        List<Floor> _building = building;
    }

    public bool closeDoors()
    {
        Console.WriteLine("Closing Doors...");
        Thread.Sleep(1000);
        Console.WriteLine("Please Stand Back...");
        Thread.Sleep(2000);
        Console.WriteLine("Doors Closed.");
        return true;
    }
    
    public bool openDoors()
    {
        Console.WriteLine("Opening Doors...");
        Thread.Sleep(1000);
        Console.WriteLine("Please Stand Back...");
        Thread.Sleep(2000);
        Console.WriteLine("Doors Opened.");
        return true;
    }
}