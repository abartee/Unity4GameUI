using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour {

    public bool inGame = false;

    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject optionMenu;
    public GameObject inGamePauseButton;

    public void Start()
    {
        inGame = false;
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        optionMenu.SetActive(false);
    }

    public void pause()
    {
        mainMenu.SetActive(false);
        pauseMenu.SetActive(true);
        optionMenu.SetActive(false);
    }

    public void options()
    {
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void closeOptions()
    {
        optionMenu.SetActive(false);

        if (inGame)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            mainMenu.SetActive(true);
        }
    }

    public void resume()
    {
        inGame = true;
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);
        optionMenu.SetActive(false);
    }

    public void quit()
    {
        inGame = false;
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        optionMenu.SetActive(false);
    }
}
