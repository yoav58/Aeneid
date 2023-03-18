using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemsSaver : MonoBehaviour
{
    public ItemsManager itm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void saveItems()
    {
        var dict = itm.getCurrentItemDict();
        foreach (string s in dict.Keys.ToList())
        {
            Debug.Log(s);
            PlayerPrefs.SetInt(s, itm.getItem(s).count);
        }
    }

    public void deleteItem(string name)
    {
        PlayerPrefs.DeleteKey(name);
    }
}
