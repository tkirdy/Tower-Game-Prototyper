using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPlayer : MonoBehaviour
{
    public Player p1;
    public Player p2;

    Player currentPlayer;

    string baseString = "Current Player = ";

    private void Start() {
        currentPlayer = p1;
        updateText();
    }

    public void updateText() {
        this.GetComponent<Text>().text = baseString + currentPlayer.playerName;
    }

    public Player getCurrentPlayer() {
        return currentPlayer;
    }

    public void endTurn() {
        if (currentPlayer == p1) {
            currentPlayer = p2;
        } else {
            currentPlayer = p1;
        }
        updateText();
    }
}
