using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RemeroShieldMethods : MonoBehaviour
{
    public Animator anim;
    
    public RameroHitMethod rhm;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "SkillAttack")
        {
            bool deffentOrNot = (Random.value >= 0.5f);
            rhm.setIsDefence(deffentOrNot);
            if (deffentOrNot)
            {
                anim.SetTrigger("Shield");
            }
        }
    }
    
    
}


