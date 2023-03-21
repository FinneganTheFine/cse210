using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
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
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Stick:Items{
    public Stick(string name, string description):base(name, description){
        _name = "Stick";
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Sword:Items{
    public Sword(string name, string description):base(name, description){
        _name = "Sword";
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Coin:Items{
    public Coin(string name, string description):base(name, description){
        _name = "Coin";
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Snail:Items{
    private List<string> tips = [
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""
    ];
    public Snail(string name, string description):base(name, description){
        _name = "Steven the Snail";
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}
class Knocker:Items{
    public Knocker(string name, string description):base(name, description){
        _name = "Knocker";
        _description = "";
    }
    public override void UseItem()
    {
        throw new NotImplementedException();
    }
}