using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour, IEnemyDamage
{
    private Animator anim;

    public float shield;
    // Start is called before the first frame update

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
   }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hitTheEnemy(float damage)
    {
        // reduce life
        anim.SetTrigger("getHit");
    }
}
