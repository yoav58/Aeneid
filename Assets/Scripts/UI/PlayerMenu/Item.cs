using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Item : MonoBehaviour
{
    public string itemName;
    public Image itemImage;
    public ItemsManager itm;
    public abstract void use();

    private void Start()
    {
        addThisItem();
    }
    
    
    /*
     * this function is to add this item into the Total possible items in the game. since
     * each item is son of this class all the items that will be created will added automaticliy.
     */
    public void addThisItem()
    {
        itm.getItemDictionary().Add(this.itemName,this);
        Debug.Log("added");
    }
}
