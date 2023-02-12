using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture _scripture1 = new Scripture();
        SetUpBoolean _hideWord1 = new SetUpBoolean(_scripture1.getVerses(), _scripture1.scriptureCount());
        Display _display1 = new Display();

        //_scripture1.loadScripture();

        _display1.loopThroughDisplays(_scripture1.totalMaxWords(), _scripture1.getVerses(), _hideWord1.getBooleanList(), _scripture1.scriptureCount(), _hideWord1, _scripture1.getTitle());
        
    }
}