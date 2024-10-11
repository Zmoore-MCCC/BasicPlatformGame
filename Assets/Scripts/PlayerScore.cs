using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    //attached to game manager
    //drag connection for guiScore
    //when we kill an enemy we will call this script to increment/set the score.
    private int playerScore;
    public TMP_Text guiScore;
    void Start()
    {
        playerScore = 0;
        //guiScore.text = "test";
    }

    public int getScore()
    {
        return playerScore;
    }

    public void setPlayerScore(int val)
    {
        playerScore += val;
        setGUIPlayerScore();
    }

    public void setGUIPlayerScore()
    {
        guiScore.text = "Score: ";
        guiScore.text += playerScore.ToString();
    }
}
