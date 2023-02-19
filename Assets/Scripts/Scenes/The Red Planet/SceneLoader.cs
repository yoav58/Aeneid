using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public string bossName;
    // Start is called before the first frame update


    public bool loadbossIsAlive()
    {
        int liveBoss = PlayerPrefs.GetInt(bossName);
        if (liveBoss == 0) return true;
        return false;
    }
}
