using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int playerScore;
    public Text PointsDisplay;
    public GameObject WinUI;
    public GameObject PlayerUI;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the initial score of the player
        playerScore = 0;
    }

    void Update()
    {
        // Allows the players score to be displayed on screen
        PointsDisplay.text = playerScore.ToString();
    }

    public void IncreaseScore()
    {
        // Will update the score & check if the win condition has been met
        playerScore = playerScore + 1;
        if(playerScore == 5)
            {
                Win();
            }
    }

    void Win()
    {
        // Displays the win screen
        WinUI.SetActive(true);
        PlayerUI.SetActive(false);
    }

}
