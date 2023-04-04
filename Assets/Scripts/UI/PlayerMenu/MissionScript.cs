using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class MissionScript : MonoBehaviour
{
    [Header("FirstMission")]
    public GameObject mission1;
    public TMP_Text missionDescription;
    public TMP_Text Location;
    
    [Header("SecondMission")]
    public GameObject mission2;
    public TMP_Text missionDescription_second;
    public TMP_Text Location_second;
    
    [Header("ThirdMission")]
    public GameObject mission3;
    public TMP_Text missionDescription_third;
    public TMP_Text Location_third;

    private int size;
    private List<Mission> missionsList;
    private List<int> codes;
    private List<int> currentCodes;
    private Dictionary<int, GameObject> missionsDict;
    // Start is called before the first frame update


    private Mission firstMission;
    private Mission secondMission;
    private Mission thirdMission;
    
    
    void Start()
    {
        size = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/******************************************************************
* Function Name: addMission
*Description:this api function, adding the mission to the menu.
*****************************************************************/
    public void addMission(string description, string location,int c)
    {
        if(missionsList == null) initializeList();
        if (codes.Contains(c)) return;
        Debug.Log(missionsList[0].isActive);
        foreach (Mission m in missionsList)
        {
            if (m.isActive == false)
            {
                initizlizeMission(m, description, location,c);
                return;
            }
        }
    }
/******************************************************************
* Function Name: initizlizeMission
*Description:this method initialize the mission 
*****************************************************************/
    private void initizlizeMission(Mission m, string d, string l,int c)
    {
        
        m.missionObject.SetActive(true);
        m.code = c;
        m.description.text = d;
        m.location.text = l;
        m.isActive = true;
        codes.Add(c);
        currentCodes.Add(c);
    }
/******************************************************************
* Function Name: deleteMission
*Description:an api method to delete mission
*****************************************************************/
    public void deleteMission(int code)
    {
        if (missionsList == null) return;
        foreach (var m in missionsList)
        {
            if (m.code == code) toggleMissions(m);
            if(string.IsNullOrEmpty(m.description.text)) removeMission(m);
        }
        
    }
/******************************************************************
* Function Name: toggleMissions
*Description:because delete mission change the order
 * of the missions in the menu, each deletion will cause to
 * toggle all the mission down
*****************************************************************/
    private void toggleMissions(Mission m)
    {
        var index = missionsList.IndexOf(m);
        toggleMissions(m, index);
    }

    private void toggleMissions(Mission m, int index)
    {
        Debug.Log(missionsList.Count);
        if (index >= missionsList.Count) return;
        if (index == missionsList.Count - 1)
        {
            removeMission(m);
            return;
        }
        else
        {
            copyMission(m, missionsList[index + 1]);
        }

        toggleMissions(missionsList[index + 1], index + 1);
    }
/******************************************************************
* Function Name: removeMission
*Description:actually remove the mission values
*****************************************************************/
    private void removeMission(Mission m)
    {
        m.missionObject.SetActive(false);
        m.isActive = false;
        currentCodes.Remove(m.code);
    }
/******************************************************************
* Function Name: copyMission
*Description:since we toggle missions, this function copy
 * the mission at index +1 place to the index place
*****************************************************************/
    private void copyMission(Mission m, Mission m2)
    {
        m.code = m2.code;
        m.description.text = m2.description.text;
        m.location.text = m2.location.text;
    }
/******************************************************************
* Function Name: initializeList
*Description:create the mission list which include all the
 * possible mission in menu (currently max 3)
*****************************************************************/
    private void initializeList()
    {
        if(codes == null) codes = new List<int>();
        if(currentCodes == null) currentCodes = new List<int>();
        firstMission = new Mission(mission1, missionDescription, Location);
        secondMission = new Mission(mission2, missionDescription_second, Location_second);
        thirdMission = new Mission(mission3, missionDescription_third, Location_third);
        missionsList = new List<Mission>
        {
            firstMission,
            secondMission,
            thirdMission
        };
    }

    public List<int> getCodes()
    {
        return codes;
    }

    public List<int> getCurrentCodes()
    {
        return currentCodes;
    }

    public void addCodes(int code)
    {
        if(codes == null) codes = new List<int>();
        codes.Add(code);
    }

    public void addToCurrent(int code)
    {
        if (currentCodes == null) currentCodes = new List<int>();
        currentCodes.Add(code);
    }

}








public class Mission
{
    public GameObject missionObject;
    public TMP_Text description;
    public TMP_Text location;
    public bool isActive;
    public int code;

    public Mission(GameObject m, TMP_Text d, TMP_Text l)
    {
        missionObject = m;
        description = d;
        location = l;
        isActive = false;
        code = 0;
        missionObject.SetActive(false);
    }
}
