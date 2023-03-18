using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItem : MonoBehaviour
{

    public string ItemName;
    public int itemCost;
    public GoldManager gm;
    public ItemsManager itm;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /******************************************************************
    * Function Name: buyItem
    *Description: eachStore should have this on each item.
    *****************************************************************/
    public void buyItem()
    {
        int currentAmountOfCoins = gm.getAmountOfCoins();
        if (currentAmountOfCoins < itemCost) return; // if not enugh coins.
        itm.addItem(this.ItemName);
        gm.removePoints(itemCost);
    }
}
