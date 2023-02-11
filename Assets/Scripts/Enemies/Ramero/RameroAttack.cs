using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RameroAttack : MonoBehaviour
{
    public float attackDamage;

    public Vector3 attackOffSet;

    public float attackRange;

    public LayerMask attackMask;
    
    public  HealthManager healthManager; // player health manager

    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffSet.x;
        pos += transform.up * attackOffSet.y;
        Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (colInfo != null && colInfo.tag == "Player")
        {
            healthManager.reduceHealth(attackDamage);
        }
    }

    private void OnDrawGizmos()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffSet.x;
        pos += transform.up * attackOffSet.y;
        Gizmos.DrawWireSphere(pos,attackRange);
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
