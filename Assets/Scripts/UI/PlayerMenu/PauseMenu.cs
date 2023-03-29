using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject ItemsMenu;
    public GameObject MissionMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f; // pause the game time.
    }

    public void ItemsClick()
    {
        pauseMenuUI.SetActive(false);
        ItemsMenu.SetActive(true);
    }

    public void itemsReturn()
    {
        ItemsMenu.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void missionsClick()
    {
        pauseMenuUI.SetActive(false);
        MissionMenu.SetActive(true);
    }

    public void missionsReturn()
    {
        MissionMenu.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
}
