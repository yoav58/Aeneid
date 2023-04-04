using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlanetCollider : MonoBehaviour
{
    public string SceneName;
    bool inRange;
    public TMP_Text massageGuide;
    public bool locked;
    public string textGuide;
    public String[] missionsCodes;
    public GameObject lockedCover;
    // Start is called before the first frame update
    void Start()
    {
        if(locked){
        locked = checkIfLocked();
        if (!locked) removeLock();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && inRange && !locked) SceneManager.LoadScene(SceneName);


    }


     void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
        //if (locked) massageGuide.text = "Locked";
        //else massageGuide.text = textGuide;
        massageGuide.text = locked ? "Locked" : textGuide;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        massageGuide.text = "";
    }

    public bool checkIfLocked()
    {
        foreach (var code in missionsCodes)
        {
            Debug.Log(code);
            if (!PlayerPrefs.HasKey(code)) return true;
        }
        Debug.Log("found");
        return false;

    }

    public void removeLock()
    {
        lockedCover.SetActive(false);
    }
    
}
