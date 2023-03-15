using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    public Image symbol;

    public string name;

    public GameObject buttons;

    public GameObject Amount;

    public Item item;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Active(Image m,string n)
    {
        symbol = m;
        name = n;
        buttons.SetActive(true);
        Amount.SetActive(true);
        count = 1;
    }

    public void addAmount()
    {
        count++;
    }

    public void decreaseAmount()
    {
        count--;
    }

}
