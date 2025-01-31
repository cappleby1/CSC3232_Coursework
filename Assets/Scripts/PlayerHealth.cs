using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxPlayerHealth = 3;
    public int currentPlayerHealth;
    public Text HealthDisplay;
    public GameObject GameOverUI;



    void Start()
    {
        // Sets the current health to the max when the game is initialised
        currentPlayerHealth = maxPlayerHealth;
    }

    void Update()
    {
        // Allows the health to be displayed as text on the players UI
        HealthDisplay.text = currentPlayerHealth.ToString();
    }

    public void TakeDamage()
    {
        // Will lower the players current health
        currentPlayerHealth = currentPlayerHealth - 1;

        // After lowering the health of the player will check if 0 has been reached to stop the game
        if(currentPlayerHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // Displays the game over screen
        GameOverUI.SetActive(true);
    }
}
