using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSight : MonoBehaviour
{
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") sawPlayer();
    }

    private void sawPlayer()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }
}
