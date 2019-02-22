using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("03a_Win_Screen");
    }

    public void QuitGame()
    {
        print("Quit Game"); // Finish this.
    }

}
