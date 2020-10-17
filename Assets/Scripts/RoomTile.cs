using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTile : Tile {
    public override int calculateValue(int row, int col) {
        Board board = GameObject.FindGameObjectWithTag("Canvas").GetComponentInChildren<Board>();
        int roomCount = 1;
        for (int i = 0; i < Board.cols; i++) {
            if (i != col && board.getCell(row, i).GetComponentInChildren<RoomTile>() != null) {
                roomCount++;
            }
        }
        Debug.Log("found " + roomCount + " rooms");
        return roomCount;
    }
}
