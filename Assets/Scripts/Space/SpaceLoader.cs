using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceLoader : MonoBehaviour
{
    
    public Dictionary<string,Transform> planets;
    public string[] planetsName;
    public Transform[] planetTransofrms;
    public GameObject spaceShip;
    // Start is called before the first frame update
    void Start()
    {
        int place = findPlanetFrom(planetsName);
        spaceShip.transform.localPosition = planetTransofrms[place].localPosition;
        DeletePlanetFrom(planetsName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int findPlanetFrom(string[] planetsName)
    {
        for (int i = 0; i < planetsName.Length; i++)
        {
            if (PlayerPrefs.GetInt(planetsName[i]) == 1) return i;
        }

        return 0;
    }

    private void DeletePlanetFrom(string[] pl)
    {
        for (int i = 0; i < pl.Length; i++)
        {
            PlayerPrefs.SetInt(pl[i], 0);
        }
    }
}
