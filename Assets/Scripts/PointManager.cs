using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public PlayerScore playerScore;

    void OnCollisionEnter(Collision collision)
    {
        // Checks if player has collided with the point object and will remove it from the game if so while increasing the score of the player
        if(collision.gameObject.tag == "Player"){
            gameObject.SetActive(false);
            playerScore.GetComponent<PlayerScore>().IncreaseScore();
        }
    }
}
