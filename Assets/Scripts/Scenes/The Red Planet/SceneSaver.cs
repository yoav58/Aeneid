using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSaver : MonoBehaviour
{
    public bool BossExists;

    public string BossName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void saveBossState(int trueOrfalse)
    {
        PlayerPrefs.SetInt(BossName, trueOrfalse); // 1 for not live 2 for living.
    }
    
}
