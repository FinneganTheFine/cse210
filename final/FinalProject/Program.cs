using System;

class Program
{
    static void Main(string[] args)
    {
        string action;
        Program.PerformAction(Console.ReadLine().ToLower());
    }
    public static void PerformAction(string action){
        switch (action){
            case "go up":
                break;
            case "go right":
                break;
            case "go down":
                break;
            case "go left":
                break;
            case "use compass":
                break;
            case "use stick":
                break;
            case "use sword":
                if (World.position == 8){

                }
                break;
            case "use coin":
                break;
            case "use snail":
                break;
            case "use knocker":
                break;
            case "use well":
                break;
        };
    }
}
public class World{
    public int position = 4;
    private List<Map> map = new List<Map>();
    public World(){
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
        map.Add(new Map("name", "description"));
    }
}
class Map{
    private string _name;
    private string _description;
    private List<Items> _itemsPresent;
    private List<Items> _usableItems;
    public Map(string name, string description){
        _name = name;
        _description = description;
    }
    public void Display(){
        Console.WriteLine($"[{_name}]");
        Console.WriteLine(_description);
        Console.WriteLine();
    }
}
abstract class Items{
    protected string _name;
    protected string _description;
    public Items(string name, string description){
        _name = name;
        _description = description;
    }
    abstract public void UseItem();
}
class Compass:Items{
    public Compass(string name, string description):base(name, description){
        _name = "Compass";
        _description = "A small spherical compass, the needle doesn't seem to work quite right";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Stick:Items{
    public Stick(string name, string description):base(name, description){
        _name = "Stick";
        _description = "It's a stick, the most versatile tool.";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Sword:Items{
    public Sword(string name, string description):base(name, description){
        _name = "Sword";
        _description = "A weapon of war, could be useful later.";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Coin:Items{
    public Coin(string name, string description):base(name, description){
        _name = "Coin";
        _description = "Money - Mr.Krabs";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Snail:Items{
    private List<string> tips = new List<string>();
    public Snail(string name, string description):base(name, description){
        _name = "Steven the Snail";
        _description = "A large snail that's wearing a suit, monocle, and tophat.";
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
        tips.Add("");
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Knocker:Items{
    public Knocker(string name, string description):base(name, description){
        _name = "Knocker";
        _description = "A brass knocker from a large door.";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Well:Items{
    public Well(string name, string description):base(name, description){
        _name = "Well";
        _description = "A darkened well, maybe you could draw some water out.";
    }
    public override void UseItem()
    {
        Console.WriteLine("You cast the bucket into the well and hear it clang against a bunch of coins, the people must have made a lot of wishes.");
    }
}