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
    private float maxXp;
    public StatesLoader sl;
    // Start is called before the first frame update

    private void Awake()
    {
        if (sl.has_load_xp())
        {
            xp = sl.LoadXP();
            level = sl.LoadLevel();
        }
    }
    void Start()
    {
        maxXp = xpView.maxValue;
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
        if(xp + added > maxXp)
        {
            level += 1;
            xp = 0;
        } else xp += added;
        
    }


    public int getLevel() { return level; }
    public float getXP() { return xp; }
}   
