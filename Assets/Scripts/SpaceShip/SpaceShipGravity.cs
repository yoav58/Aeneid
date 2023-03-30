using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipGravity : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
                rb = GetComponent<Rigidbody>();
        
                // Disable gravity for the Rigidbody
                rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
