using UnityEngine.Events;

public enum SystemicMaterial
{
    WOOD,
    GRASS,
    ICE,
    WATER,
    IRON,

}

public enum SystemicElement
{
    WATER,
    FIRE,
    WIND,
    COLD,
    ELECTRICITY,
}

public enum ElementSize
{
    NONE,
    SMALL,
    MEDIUM,
    BIG,
}

// callback when a material hit an element
[System.Serializable]
public struct MaterialReaction
{
    public SystemicElement theElement;
    public ElementSize theSize;
    public UnityEvent actions;
}

// callback when an element hit an element
[System.Serializable]
public struct ElementReaction
{
    public SystemicElement theElement;
    public ElementSize theSize;
    public UnityEvent actions;
}

public static class Data
{
    //return -1 if elem1 is stronger, 0 is both are equal, 1 is elem2 is stronger
    public static int GetStrongerElement(SystemicElement elem1, SystemicElement elem2)
    {
        switch (elem1)
        {
            case SystemicElement.FIRE:
            {
                switch (elem2)
                {
                    case SystemicElement.WATER:
                        return 1;
                }
                break;
            }
        }
        return 0;
    }

}
