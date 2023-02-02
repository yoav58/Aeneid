using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("FightScene");
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
