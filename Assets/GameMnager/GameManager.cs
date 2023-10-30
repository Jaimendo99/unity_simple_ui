using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToGame()
    {
        Debug.Log("Go to Game");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        
    }

    public void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
