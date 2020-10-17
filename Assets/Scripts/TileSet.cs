using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSet : MonoBehaviour
{
    List<Tile> tiles = new List<Tile>();
    public ElevatorTile ElevatorTile;
    public RoomTile RoomTile;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize tile set
        tiles.Add(ElevatorTile);
        tiles.Add(RoomTile);
        Debug.Log("initialization complete");
    }

    public Tile getRandomTile()
    {
        int index = Random.Range(0, tiles.Count);
        Tile target = Instantiate(tiles[index]) as Tile;
        Debug.Log("index = " + index);
        return target;
    }
}
