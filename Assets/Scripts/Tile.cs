using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Tile : Draggable {
    public int value = 0;

    public abstract int calculateValue(int row, int col);
}
