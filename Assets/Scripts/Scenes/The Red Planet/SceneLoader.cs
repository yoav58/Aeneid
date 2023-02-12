using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update


    public bool loadbossIsAlive()
    {
        int liveBoss = PlayerPrefs.GetInt("Boss");
        if (liveBoss == 0) return true;
        return false;
    }
}
