using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCollider : MonoBehaviour
{
    public GoldManager gm;
    // Start is called before the first frame update
    void Start()
    {
       gm =  GameObject.Find("UImanager").GetComponent<GoldManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gm.addCoin(1);
            Destroy(gameObject);
        }
    }
}
