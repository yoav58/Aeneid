using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class MissionSaverLoader : MonoBehaviour
{

    public MissionScript ms;
    private List<int> codes;
    private List<int> currentCodes;
    public MissionOption[] missions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void save()
    {
        codes = ms.getCodes();
        currentCodes = ms.getCurrentCodes();
        if (codes == null)
        {
            return;
        }
        foreach (var code in codes)
        {
            PlayerPrefs.SetInt(code.ToString(),1);
        }
        foreach (var code in currentCodes)
        {
            PlayerPrefs.SetInt(code.ToString(),2);
        }
        
    }

    public void load()
    {
        foreach (var m in missions)
        {
            int savedType = PlayerPrefs.GetInt(m.code.ToString());
            if (savedType != 0)
            {
                if (savedType == 1)
                {
                    ms.addCodes(m.code);
                }
                ms.addMission(m.description,m.location,m.code);

            }
        } 
    }


    
}
