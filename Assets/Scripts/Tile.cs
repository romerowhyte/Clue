using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum TileType
    {
        T, //Tile
        TT, //Traversable
        WT //Wall
        RT //Room
    }

    protected TileType tileType;
    
    //board co-ords
    public int X {get; set; }
    public int Y {get; set; }

    //checks if occupied 
    public bool IsOccupied {get; set; } = false;

    public virtual void Start() {
        tileType = TitleType.T;
    }

    public abstract bool IsWalkable();

    
    public TileType GetTileType() => tileType;
}

