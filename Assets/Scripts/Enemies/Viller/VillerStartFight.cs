using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VillerStartFight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("start");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("start2");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("start3");

    }
}
