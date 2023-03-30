using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsMenuScript : MonoBehaviour
{

    public GoldManager glm;
    public ExpManager expm;

    public int level;
    public TMP_Text levelText;
    public TMP_Text coinText;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void voidUpdateStates()
    {
        levelText.text = expm.getLevel().ToString();
        coinText.text = glm.coins.text;
    }

    private void OnEnable()
    {
        voidUpdateStates();
    }
}
