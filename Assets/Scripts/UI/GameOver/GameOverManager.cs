using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public string sceneName;
    public GameObject GeneralUI;
    // Start is called before the first frame update
    public void showGameOver()
    {
        GeneralUI.SetActive(false);
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
