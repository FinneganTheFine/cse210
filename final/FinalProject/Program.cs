using System;
using System.Threading;

class Program
{
    static World world = new World();
    static void Main(string[] args)
    {
        //Currently you start with all the items already on you
        world.Place();
        while (world.gaming != false){
            Program.PerformAction(Console.ReadLine().ToLower());
            world.Place();
        }
    }
    public static void PerformAction(string action){
        switch (action){
            case "go north":
                if(world.position == 0){
                    Console.WriteLine("You don't want to get more lost in the trees.");
                    break;
                } else if(world.position == 1){
                    Console.WriteLine("That's a lot of forest, are you sure about that?");
                    break;
                } else if(world.position == 2){
                    Console.WriteLine("You don't really feel like going that way.");
                    break;
                } else if(world.position == 3){
                    world.position -= 3;
                    break;
                } else if(world.position == 4){
                    world.position -= 3;
                    break;
                } else if(world.position == 5){
                    world.position -= 3;
                    break;
                } else if(world.position == 6){
                    world.position -= 3;
                    break;
                } else if(world.position == 7){
                    world.position -= 3;
                    break;
                } else if(world.position == 8){
                    Console.WriteLine("That is a lot of wall that you're walking into.");
                    break;
                } else {
                    break;
                }
            case "go east":
                if(world.position == 0){
                    Console.WriteLine("That's a lot of forest, are you sure about that?");
                    break;
                } else if(world.position == 1){
                    world.position += 1;
                    break;
                } else if(world.position == 2){
                    Console.WriteLine("You don't really feel like going that way.");
                    break;
                } else if(world.position == 3){
                    world.position += 1;
                    break;
                } else if(world.position == 4){
                    world.position += 1;
                    break;
                } else if(world.position == 5){
                    Console.WriteLine("I don't know, there's a lotta rocks and trees over there and I don't really feel like it.");
                    break;
                } else if(world.position == 6){
                    Console.WriteLine("Can't go there, Mansion fell down.");
                    break;
                } else if(world.position == 7){
                    if(world.knocked == true){
                        world.position +=1;
                    } else {
                        Console.WriteLine("Two large doors block the entrance to the cave, and it's rude to enter without knocking");
                    }
                    break;
                } else if(world.position == 8){
                    Console.WriteLine("That is a lot of wall that you're walking into.");
                    break;
                } else {
                    break;
                }
            case "go south":
                if(world.position == 0){
                    world.position += 3;
                    break;
                } else if(world.position == 1){
                    world.position += 3;
                    break;
                } else if(world.position == 2){
                    world.position += 3;
                    break;
                } else if(world.position == 3){
                    world.position += 3;
                    break;
                } else if(world.position == 4){
                    world.position += 3;
                    break;
                } else if(world.position == 5){
                    Console.WriteLine("That's a lot of mountain to climb, and the cave isn't even on top of it.");
                    break;
                } else if(world.position == 6){
                    Console.WriteLine("There's just forest and rubble that way, So maybe let's not go there.");
                    break;
                } else if(world.position == 7){
                    Console.WriteLine("Wow, that is a lot of trees that I do not want to walk through.");
                    break;
                } else if(world.position == 8){
                    Console.WriteLine("That is a lot of wall that you're walking into.");
                    break;
                } else {
                    break;
                }
            case "go west":
                if(world.position == 0){
                    Console.WriteLine("You don't want to get more lost in the trees.");
                    break;
                } else if(world.position == 1){
                    Console.WriteLine("That's a lot of forest, are you sure about that?");
                    break;
                } else if(world.position == 2){
                    world.position -= 1;
                    break;
                } else if(world.position == 3){
                    Console.WriteLine("Too many trees, pass.");
                    break;
                } else if(world.position == 4){
                    world.position -= 1;
                    break;
                } else if(world.position == 5){
                    world.position -= 1;
                    break;
                } else if(world.position == 6){
                    Console.WriteLine("That is too much forest for me to bother walking through.");
                    break;
                } else if(world.position == 7){
                    Console.WriteLine("You see what looks like smoldering rubble mixed in with the trees, and that is a bad omen, so you're not going that way.");
                    break;
                } else if(world.position == 8){
                    Console.WriteLine("That is a lot of wall that you're walking into.");
                    break;
                } else {
                    break;
                }
            case "use compass":
                if (world.position == 1){
                    world.ItemUsed(world.position, "Shabby Village", world.UseItem(0));
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "use stick":
                if (world.position == 6){
                    world.ItemUsed(world.position, "The Warrior's Manor", world.UseItem(1));
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "use sword":
                if (world.position == 8){
                    world.ItemUsed(world.position, "Dragon", world.UseItem(2));
                    world.gaming = false;
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "use coin":
                if (world.position == 8){
                    world.ItemUsed(world.position, "Dragon", world.UseItem(3));
                    world.gaming = false;
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "use snail":
                Console.WriteLine(world.UseItem(4));
                break;
            case "use knocker":
                if (world.position == 7){
                    world.ItemUsed(world.position, "Shabby Village", world.UseItem(5));
                    world.knocked = true;
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "use well":
                if (world.position == 0){
                    world.ItemUsed(world.position, "Old Well", world.UseItem(6));
                    break;
                } else {
                    Console.WriteLine("You don't think that this is the right place to use this.");
                    break;
                }
            case "open chest":
                world.ItemUsed(world.position, "The Not Suspicious Chest", "Boldly you go and open the chest, inside is a compass in prestine condition.");
                break;
        };
    }
}
public class World{
    public int position = 4;
    public bool knocked = false;
    private List<Map> map = new List<Map>();
    private List<Items> items = new List<Items>();
    public bool gaming;
    public World(){
        //Generate map array
        map.Add(new Map("Old Well", "You see an old well, it must be the wishing well that Hourse was talking about", (new string[]{"use well","go south"})));
        map.Add(new Map("Shabby Village", """You follow the north path and find a shabby village with one house, seemingly untouched by age. Outside of the house is an old man, sitting on a rocking chair\nYou walk up to the old man. He looks up at you from his chair and says, "Hello there! Do you happen to know where I am? I'm rather lost. I'm looking for my family, but I dropped my compass. Have you seen it?" """, (new string[]{"go east","go south","use compass"})));
        map.Add(new Map("Bushes", """You wade through bushes as you continue on your journey. You begin to step forward, until you hear a voice say, "Well hello! I've been looking for you. " You look around and see a snail. The snail is quite daper, as he is wearing a tophat, suit and monocle. The snail slowly climbs onto your shoulder. "I will join you on your journey.""", (new string[]{"go south", "go west"})));
        map.Add(new Map("Hourse", """You walk west. After a a few minutes of walking you find a horse in the middle of the road. Strangley the horse is standing on its hind legs. As you approach, the horse notices you and says, "Heallo. I am HOURSE." He lifts his "arms?" and points to the north or south. "To the scouth, tear is a mobile warriors house. To the nort, der is de old wishin whale. Many have made wishin ther." After telling you these things, the hourse gets on all fours and hops on a tree, which promptly blasts of into space.""", (new string[]{"go north", "go east","go south"})));
        map.Add(new Map("Forest", "You wake up in a forest filled to the brim with trees. You look around you, and find that you're in the middle of a crossroads that go North, South, East, and West. Along the crossroads, you see sticks scattered about the forest floor.", (new string[]{"go north", "go east","go south", "go west"})));
        map.Add(new Map("The Not Suspicious Chest", "You wander east. You then come across a meadow, beautiful and full of flowers and butterflies. There is a bright beam of light shining down on a single chest. This chest isn't suspicious at all.", (new string[]{"go north","go west", "open chest"})));
        map.Add(new Map("The Warrior's Manor", """You come through the trees and are met with the site of a beautiful manor. Okay so the manor would probably look better if it was more than a pile of old rubble scuttered through a clearing, but it's not that bad.\nWandering through the rubble you find a skeleton gripping a sword. You assume this is the warrior. He's not using the sword so you might as well take it. When you try and take the sword the skeleton grips tighter on the sword and in a bone shaking voice says "No, it's mine, my sword". """, (new string[]{"go north","use stick"})));
        map.Add(new Map("The dragon's front door", """You walk south and find yourself at the base of a mountain. A man with frizzy, unkept hair runs at you. Well, less of a run and more of a speedy penguin waddle. As he gets closer you notice a name tag stuck in his hair that says "Joe". "Aye yo, be careful my guy! Right o'r there east through those big doors is a dragon! Okay bye!" and the man runs off.""", (new string[]{"go north", "go east","use knocker"})));
        map.Add(new Map("Dragon", """As you enter the dragon's cave steam billows around you. You see the light of flames and smell smoke as you move farther into the cave. "Darn it! all this steam is setting off my allergies!". You jump at the voive shouting from behind the curtain of steam. As you pass through the steam you see a gargantuan figure looming over you, its crimson red scales glistening in the firelight. The creature lowers it's head to your level then opens its mouth saying, "Oh hello there, I didn't realize you were already here. I would have come to great you myself but this blasted steam has me sneezing oh so terribly". Looking you up and down the dragon curiously inquires, "What'd you bring me?" """, (new string[]{"go west","use coin", "use sword"})));

        //Generate items array
        var compass = new Compass("", "");
        var stick = new Stick("", "");
        var sword = new Sword("", "");
        var coin = new Coin("", "");
        var snail = new Snail("", "");
        var knocker = new Knocker("", "");
        var well = new Well("", "");
        items.Add(compass);
        items.Add(stick);
        items.Add(sword);
        items.Add(coin);
        items.Add(snail);
        items.Add(knocker);
        items.Add(well);

        gaming = true;
    }
    public string UseItem(int i){
        return items[i].UseItem();
    }
    public void ItemUsed(int i, string name, string description){
        string descraption = map[i].Description();
        string[] options = map[i].Options();
        descraption += $"\n{description}";
        map[i] = new Map(name, descraption, options);
    }
    public void Place(){
        map[position].Display();
    }
}
class Map{
    private string _name;
    private string _description;
    private List<Items> _itemsPresent;
    private List<Items> _usableItems;
    private string[] _options;
    public Map(string name, string description, string[] options){
        _name = name;
        _description = description;
        _options = options;
    }
    public void Display(){
        Console.Clear();
        Console.WriteLine($"[{_name}]");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Options: ");
        foreach(var line in _options){
            Console.Write($"{line}, ");
        }
        Console.WriteLine();
    }
    public string Description(){
        return _description;
    }
    public string[] Options(){
        return _options;
    }
}
abstract class Items{
    protected string _name;
    protected string _description;
    public Items(string name, string description){
        _name = name;
        _description = description;
    }
    abstract public string UseItem();
}
class Compass:Items{
    public Compass(string name, string description):base(name, description){
        _name = "Compass";
        _description = "A small spherical compass, the needle doesn't seem to work quite right";
    }
    public override string UseItem()
    {
        return """The old man smiles at you, thanks you for the compass, looks at it while turning to face the house, then he opens the door and exclaims, "Oh my family, I have finally found you" You hear someone inside the house say, "Grandpa did you get lost sitting on the porch again" before the door closes behind the man. Suddenly a brass knocker flies out of the second story window and smashes into the ground next to you.""";
    }
}
class Stick:Items{
    public Stick(string name, string description):base(name, description){
        _name = "Stick";
        _description = "It's a stick, the most versatile tool.";
    }
    public override string UseItem()
    {
        return "You wack the skeleton a couple of times with the stick, how rude of you, before it grumbles a couple of quite rude statements under it's breath before lettimg go of the sword.";
    }
}
class Sword:Items{
    public Sword(string name, string description):base(name, description){
        _name = "Sword";
        _description = "A weapon of war, could be useful later.";
    }
    public override string UseItem()
    {
        return """ "You dare to attack me!!!" Roars the dragon as he bites down on your head killing you""";
    }
}
class Coin:Items{
    public Coin(string name, string description):base(name, description){
        _name = "Coin";
        _description = "Money - Mr.Krabs";
    }
    public override string UseItem()
    {
        return """ "Oh is that for me? Why thank you. I must do something to thank you for... AHG AHG AHG AHG AHG AHG". You fling up into a sitting position, but how did you end up laying down. looking around you find yourself in your bedroom, your alarm clock making its usual horrible AHG noise, it was all a dream.\n\nThanks for Playing """;
    }
}
class Snail:Items{
    private List<string> tips = new List<string>();
    public Snail(string name, string description):base(name, description){
        _name = "Steven the Snail";
        _description = "A large snail that's wearing a suit, monocle, and tophat.";
        tips.Add("Oh ->Well<-, guess that's all that's here");
        tips.Add("The old man looks like he needs help finding his bearings");
        tips.Add("There's just bushes where I was");
        tips.Add("There's a super not suspicious chest somewhere.");
        tips.Add("Dragon's aren't so bad.");
        tips.Add("I want lunch, I'm hungry");
        tips.Add("What use could a sword have, that blade lacks elegance.");
        tips.Add("I don't have any advice right now, super lost.");
        tips.Add("Dragons Like Gold.");
    }
    public override string UseItem()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(9);
        return tips[promptIndex];
    }
}
class Knocker:Items{
    public Knocker(string name, string description):base(name, description){
        _name = "Knocker";
        _description = "A brass knocker from a large door.";
    }
    public override string UseItem()
    {
        return "You fit the knocker to the large doors and knock three times. With a loud roar the doors slide open, steam billows out of the now open entrance.";
    }
}
class Well:Items{
    public Well(string name, string description):base(name, description){
        _name = "Well";
        _description = "A darkened well, maybe you could draw some water out.";
    }
    public override string UseItem()
    {
        return "You cast the bucket into the well and hear it clang against a bunch of coins, the people must have made a lot of wishes.";
    }
}