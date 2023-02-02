using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour, DamageEnemyI
{
    private Animator anim;

    public VillerLifeBar vlf;
    public ExpManager playerXP;
    public float xp_reward;

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
        float newDamage = damage * shield;
        // reduce life
        anim.SetTrigger("getHit");
        vlf.reduceLife(newDamage);
    }

    public void killMonster()
    {
        //anim.SetTrigger("Died");
        playerXP.addXP(xp_reward);
    }
}
