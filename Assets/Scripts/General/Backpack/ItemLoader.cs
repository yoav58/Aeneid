using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour
{

    public ItemsManager itm;

    public string[] itemsPossible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadAllItems()
    {
        foreach (var s in itemsPossible)
        {
            if (PlayerPrefs.HasKey(s))
            {
                int amount = PlayerPrefs.GetInt(s);
                itm.addItemFromLoad(s,amount);
            }
        }
    }
    
    
}
