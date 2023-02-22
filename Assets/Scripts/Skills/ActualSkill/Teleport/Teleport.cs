using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject player;
    private GameObject teleportPlace;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        player = GameObject.Find("Agent");
        teleportPlace = GameObject.Find("TeleportTarget");
        print(player.transform.position);
        player.transform.position = teleportPlace.transform.position;
        var agn = player.GetComponentInChildren<AgentAnimation>();
        agn.doSkillFalse();
        
        
    }
}
