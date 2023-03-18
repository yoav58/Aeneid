using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{

    public Dictionary<string, int> place = new Dictionary<string, int>();
    public ItemManager[] itemList;
    public int size;
    public int maxSize = 12;
    public Dictionary<string, Item> possibleItems = new Dictionary<string, Item>();
    public ItemLoader itl;
    public bool FirstTimeInScene;



    // Start is called before the first frame update
    void Start()
    {
        FirstTimeInScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (FirstTimeInScene)
        {
            itl.loadAllItems();
            FirstTimeInScene = false;
        }
    }
    /******************************************************************
    * Function Name: addItem
    *Description: add item into the backpack. the logic here is first
     * check if the item exist by using dictionary, if not add him
     * to backpack and to empty slot.
    *****************************************************************/
    public bool addItem(string itemName)
    {
        if (size == maxSize) return false;
        if (place.ContainsKey(itemName))
        {
            int index = place[itemName];
            itemList[index].addAmount();
        }
        else
        {
            int index = size;
            ++size;
            place.Add(itemName,index);
            itemList[index].Active(possibleItems[itemName]);
        }

        return true;
    }
    /******************************************************************
    * Function Name: getItemDictionary
    *Description: each item in the game should add himself to the Dictionary.
    *****************************************************************/
    public Dictionary<string, Item> getItemDictionary()
    {
        return this.possibleItems;
    }

    public void removeItem(string itemName)
    {
        place.Remove(itemName);
        --size;
    }

    public ItemManager getItem(string itemName)
    {
        int index = place[itemName];
        return itemList[index];
    }

    public void addItemFromLoad(string itemName,int amount)
    {
        int index = size;
        ++size;
        place.Add(itemName,index);
        itemList[index].Active(possibleItems[itemName]);
        itemList[index].SetAmount(amount);
    }

    public Dictionary<string, int> getCurrentItemDict()
    {
        return this.place;
    }
}
