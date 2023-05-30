using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellorReward : Reward
{
    public string rewardName;
    public StoreItem items;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void GetReward()
    {
        if (PlayerPrefs.GetInt(rewardName) == 1) return;
        //items.CostDiscount(2);
        PlayerPrefs.SetInt(rewardName,1);
        Debug.Log("get reward");
    }
}
