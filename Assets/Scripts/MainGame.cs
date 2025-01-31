using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu;

    [SerializeField]
    GameObject gameUI;

    enum GameMode
    {
        InGame,
        MainMenu,
    }

    GameMode gameMode = GameMode.MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        StartMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        switch(gameMode)
        {
            case GameMode.MainMenu:     UpdateMainMenu(); break;
        }
    }

    // Checks if the player presses the key to begin the game
    void UpdateMainMenu()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    // Brings up the main menu which will stop the player interacting before starting the game
    void StartMainMenu()
    {
        gameMode = GameMode.MainMenu;
        mainMenu.gameObject.SetActive(true);
        gameUI.gameObject.SetActive(false);
    }

    // Will allow the player to interact with the game and remove the menu
    void StartGame()
    {
        gameMode = GameMode.InGame;
        mainMenu.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(true);
    }
}
