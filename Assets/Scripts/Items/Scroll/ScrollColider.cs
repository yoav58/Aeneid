using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollColider : MonoBehaviour
{
    public MissionScript ms;
    public int missionNumber = 3;
    public missionsFinishedManager mfm;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") pickedUp();
    }
    /**************************************************************
     * Function Name: PickedUp
     * Description: when the player get the scroll, update in the
     * memory.
     *************************************************************/
    private void pickedUp()
    {
        PlayerPrefs.SetInt("Scroll",1);
        ms.deleteMission(missionNumber);
        if(mfm != null) mfm.finishedMission();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Scroll") == 1) Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
