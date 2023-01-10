using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillerAttack : MonoBehaviour
{
    public float damage;
    public Vector3 attacOffset;
    public float attackRange;
    public LayerMask attackMask;
    private Transform ts;
    private Vector3 pos;
    public HealthManager playerHealth;

    private void Awake()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        pos = transform.position;
        pos += transform.right * attacOffset.x;
        pos += transform.up * attacOffset.y;
        Gizmos.DrawWireSphere(pos,attackRange);
    }

    public void AttackPlayer()
    {
        if(playerInAttackRange()) reduceLife();
    }
    
    
    private bool playerInAttackRange()
    {
        pos = transform.position;
        pos += transform.right * attacOffset.x;
        pos += transform.up * attacOffset.y;
        Collider2D col = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (col != null && col.name == "GroundColider")
        {
            return true;
        }

        return false;
    }

    private void reduceLife()
    {
        playerHealth.reduceHealth(damage);
    }
    
}
