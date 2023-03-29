using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionTester : MonoBehaviour
{
    public MissionScript ms;
    public string description;
    public string location;
    public int code;
    public bool add;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if(add) ms.addMission(description,location,code);
            else ms.deleteMission(code);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
