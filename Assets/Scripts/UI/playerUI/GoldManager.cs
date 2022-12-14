using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public TMP_Text coins;
    private int totalCoins = 0;
    public StatesLoader stl;
    // Start is called before the first frame update
    void Start()
    {
        if (stl.has_load_coins()) totalCoins = stl.LoadCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        coins.text = totalCoins.ToString();
    }



    public void addCoin(int amount)
    {
        totalCoins += amount;
    }

    public void removePoints(int amount)
    {
        totalCoins -= amount;
    }

    public int getAmountOfCoins()
    {
        return totalCoins;
    }
}
