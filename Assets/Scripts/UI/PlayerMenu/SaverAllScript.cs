using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaverAllScript : MonoBehaviour
{
    public StatesSaver sts;

    public MissionSaverLoader msl;

    public ItemsSaver Is;

    public SpaceShipCollider sph;
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
        sts.SaveGame();
        msl.save();
        Is.saveItems();
        sph.saveSpaceLocation();
    }
}
