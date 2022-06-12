//An Enum type defines a set of constant values 
public enum Colors
{
    Red,
    Green,
    Blue
}

public enum Seasons
{
    Rainy = 0,
    Dry = 1,

    Harmattan = 2,
    All = Rainy | Dry | Harmattan
}
