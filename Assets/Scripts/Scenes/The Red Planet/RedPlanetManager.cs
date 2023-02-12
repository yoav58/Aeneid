using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlanetManager : MonoBehaviour
{
    public SceneLoader scl;
    public SceneSaver scs;
    public GameObject bossArena;
    
    // Start is called before the first frame update
    void Start()
    {
        if(scl.loadbossIsAlive()) bossArena.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
