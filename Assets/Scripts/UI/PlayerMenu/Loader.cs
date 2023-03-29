using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public MissionSaverLoader ms;
    // Start is called before the first frame update
    void Start()
    {
        ms.load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
