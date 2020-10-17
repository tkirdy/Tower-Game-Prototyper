using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int score = 0;
    public Scoreboard board;

    public void addPoints(int points) {
        score += points;
        board.updateScore();
    }
}
