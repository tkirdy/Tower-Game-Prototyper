using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTile : Tile {
    public override int calculateValue(int row, int col) {
        Board board = GameObject.FindGameObjectWithTag("Canvas").GetComponentInChildren<Board>();
        int connectedFloors = 0;
        if (row != 0) {
            for (int i = row-1; i >= 0; i--) {
                if (board.getCell(i, col).GetComponentInChildren<ElevatorTile>() != null) {
                    connectedFloors++;
                } else {
                    break;
                }
            }
        }
        if (row != Board.rows) {
            for (int i = row+1; i <= Board.rows; i++) {
                if (board.getCell(i, col).GetComponentInChildren<ElevatorTile>() != null) {
                    connectedFloors++;
                }
                else {
                    break;
                }
            }
        }
        Debug.Log("found " + connectedFloors + " connected floors");
        return connectedFloors * 2;
    }
}
