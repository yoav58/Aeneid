using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlace : MonoBehaviour
{
    public Transform agentPlace;
    public Transform currentPlace;

    private void Awake()
    {
        currentPlace = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPlace.localScale = new Vector3(agentPlace.localScale.x, currentPlace.localScale.y, currentPlace.localScale.z);
    }
}
