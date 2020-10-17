using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {
    public Player player;
    public void updateScore() { 
        this.GetComponent<Text>().text = "Score = " + player.score;
    }
}
