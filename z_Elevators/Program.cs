class Program
{
    static void Main(string[] args)
    {
        List<Floor> building = new List<Floor>();
        for (int x = 0; x < 32; x++)
        {
            Floor floor1 = new Floor(x);
            building.Add(floor1);
        }
        Elevator vator1 = new Elevator(building);
        Elevator VIPvator = new Elevator(true);
    }
}