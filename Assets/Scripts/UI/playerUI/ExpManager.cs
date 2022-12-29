using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpManager : MonoBehaviour
{

    public Slider xpView;
    float xp;
    int level;
    public int maxLevel;
    public int minLevel;
    private int maxXp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        xpView.value = xp;
    }


    public void addXP(float added)
    {
        xp += added;
    }
}
