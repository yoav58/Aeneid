using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class to get all stats in game.

public class Stats : MonoBehaviour
{


    public ExpManager m_xp;
    public HealthManager m_hel;
    public GoldManager m_gd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getXp()
    {
        return m_xp.getXP();
    }

    public int getLevel()
    {
        return m_xp.getLevel();
    }

    public int getCoins()
    {
        return m_gd.getAmountOfCoins();
    }

    public float getHealth()
    {
        return m_hel.getHealth();
    }

}
