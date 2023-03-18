using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public ItemsManager itm;
    public Image symbol;
    public GameObject symbolObject;
    public ItemsSaver itemSave;
    public string name;

    public GameObject buttons;

    public GameObject Amount;
    public TMP_Text amountText;

    public Item item;

    public bool isNull = true;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /******************************************************************
    * Function Name: Active
    *Description: simply make this slot active with item.
    *****************************************************************/
    public void Active(Item item)
    {
        symbolObject.SetActive(true);
        symbol.sprite = item.itemImage.sprite;
        name = item.itemName;
        buttons.SetActive(true);
        Amount.SetActive(true);
        isNull = false;
        count = 1;
        this.item = item;
        updateAmount();
    }

    public void addAmount()
    {
        count++;
        updateAmount();
    }

    public void decreaseAmount()
    {
        count--;
        if(count > 0) updateAmount();
        else
        {
            removeItem();
        }
    }

    private void updateAmount()
    {
        string s = count.ToString();
        amountText.SetText(s);
    }

    public void SetAmount(int c)
    {
        count = c;
        updateAmount();
    }
    /******************************************************************
    * Function Name: RemoveItem
    *Description: remove the item from the backpack and also from the
     * slot.
    *****************************************************************/
    public void removeItem()
    {
        itemSave.deleteItem(name);
        itm.removeItem(name);
        symbolObject.SetActive(false);
        name = null;
        buttons.SetActive(false);
        Amount.SetActive(false);
        isNull = true;
    }

    public void useItem()
    {
        item.use();
        decreaseAmount();
    }


}
