using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    public Button drawButton;
    public TileSet tileSet;
    public Transform hand;

    // Start is called before the first frame update
    void Start()
    {
        Button button = drawButton.GetComponent<Button>();
        button.onClick.AddListener(getNewTiles);
    }

    void getNewTiles()
    {
        if (hand.childCount < 3) {
            Tile newTile = tileSet.getRandomTile();
            Debug.Log("new tile = " + newTile.name);
            newTile.transform.SetParent(hand);
        }
    }
}
