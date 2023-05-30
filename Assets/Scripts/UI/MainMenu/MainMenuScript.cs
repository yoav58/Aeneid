using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("FirensPlanetScene");
    }
    // Start is called before the first frame update


    // for "new Game" button.
    public void newGame()
    {
        PlayerPrefs.DeleteAll();
        playGame();
    }

    public void loadGame()
    {
        playGame();
    }

    public void quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
