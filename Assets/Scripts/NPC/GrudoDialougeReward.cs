using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrudoDialougeReward : ColliderDialogue
{
    public int goldAward;
    public GoldManager gm;
    public MissionOption[] missions;
    public MissionScript missionManager;
    
    public override void awardMethod()
    {
        gm.addCoin(goldAward);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void addMissions()
    {
        foreach (var m in missions)
        {
            missionManager.addMission(m.description,m.location,m.code);
        }
    }
}
