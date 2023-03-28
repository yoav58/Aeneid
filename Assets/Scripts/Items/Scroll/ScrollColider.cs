using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollColider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") pickedUp();
    }

    private void pickedUp()
    {
        PlayerPrefs.SetInt("Scroll",1);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
