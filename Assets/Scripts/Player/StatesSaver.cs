using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class StatesSaver : MonoBehaviour
{

    public Stats stats;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveGame()
    {
        saveCoins();
        saveHealth();
        saveXp();
        saveLevel();
    }


/******************************************************************
* those methods are to save the game stats.
*****************************************************************/
    private void saveXp()
    {
        PlayerPrefs.SetFloat("XP", stats.getXp());
    }

    private void saveHealth()
    {
        PlayerPrefs.SetFloat("Health", stats.getHealth());
    }
    private void saveCoins()
    {
        PlayerPrefs.SetInt("Coins", stats.getCoins());
    }

    private void saveLevel()
    {
        PlayerPrefs.SetInt("Health", stats.getLevel());
    }





}
