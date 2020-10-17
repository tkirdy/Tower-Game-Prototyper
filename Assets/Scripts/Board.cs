using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour {

    public static int rows = 8;
    public static int cols = 7;

    public Cell cellPrefab;
    private Cell[,] cells = new Cell[rows, cols];
    void Start() {
        for (int row = 0; row < 8; row++) {
            for (int col = 0; col < 7; col++) {
                Cell cell = Instantiate(cellPrefab, this.transform, false);
                cell.row = row;
                cell.col = col;
                cells[row, col] = cell;
            }
        }
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }

    public Cell getCell(int row, int col) {
        return cells[row, col];
    }
}
