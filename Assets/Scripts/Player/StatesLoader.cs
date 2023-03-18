using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesLoader : MonoBehaviour
{
    public bool newGame = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


/******************************************************************
* those methods is to loads the game from last saved game.
*****************************************************************/

    public int LoadCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public float LoadXP()
    {
        return PlayerPrefs.GetFloat("XP");
    }

    public float LoadHealth()
    {
        return PlayerPrefs.GetFloat("Health");
    }

    public int LoadLevel()
    {
        return PlayerPrefs.GetInt("Level");
    }

    public bool has_load_coins()
    {
        return PlayerPrefs.HasKey("Coins");
    }

    public bool has_load_xp()
    {
        return PlayerPrefs.HasKey("XP");
    }

    public bool has_load_Health()
    {
        return PlayerPrefs.HasKey("Health");
    }

    public bool has_load_Level()
    {
        return PlayerPrefs.HasKey("Level");
    }
    

}
