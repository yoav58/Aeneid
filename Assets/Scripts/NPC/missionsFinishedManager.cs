using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionsFinishedManager : MonoBehaviour
{

    public string missionName;
    private int missionCurrentCount = 0;
    public int missionCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        finishedMission();
        Debug.Log(missionCurrentCount);
    }


    public void finishedMission()
    {
         missionCurrentCount = PlayerPrefs.GetInt(missionName);
        if(missionCurrentCount == 0) PlayerPrefs.SetInt(missionName,++missionCurrentCount);
        else if (missionCurrentCount == missionCount) return;
        else {
        missionCurrentCount += 1;
        PlayerPrefs.SetInt(missionName,missionCurrentCount);
        }
    }
}
