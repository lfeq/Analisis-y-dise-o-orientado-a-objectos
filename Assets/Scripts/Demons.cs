public abstract class Demons
{
    public abstract void PowerUp();

    public abstract string GetName();

    public abstract string GetDescription();
}

public class InterfaceDemon : Demons {
    private string name;
    private string description;
    //private Sprite icon;
    //private Sprite sello;
    private int legions;
    private string direction;
    private string planet;
    private string metal;
    private string element;

    public InterfaceDemon(string name, string description, int legiones, string direction, string planet, string metal, string element) {
        this.name = name;
        this.description = description;
        this.legions = legiones;
        this.direction = direction;
        this.planet = planet;
        this.metal = metal;
        this.element = element;
    }

    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }
    public int Legions { get { return legions; } set { legions = value; } }
    public string Direction { get { return direction; } set { direction = value; } }
    public string Planet { get { return planet; } set { planet = value; } }
    public string Metal { get { return metal; } set { metal = value; } }
    public string Element { get { return element; } set { element = value; } }

    public override void PowerUp() {
    }

    public override string GetName() {
        return name;
    }

    public override string GetDescription() {
        return description;
    }
}
