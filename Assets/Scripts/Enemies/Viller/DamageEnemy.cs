using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : EnemyMethods, IEnemyDamage
{
    private Animator anim;
    private EnemyLifeBar lifeBar;
    public ExpManager playerXP;
    public float xpReward;
    public GameObject exitArena;
    public SceneSaver scs;
    public int missionCode;
    public MissionScript missionManager;


    public float shield;
    // Start is called before the first frame update

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        lifeBar = GetComponentInChildren<EnemyLifeBar>();
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
        anim.SetTrigger("getHit");
        damage = damage * ( (100-shield) / 100);
        lifeBar.reduceLife(damage);
    }

    public override void killMonster()
    {
        playerXP.addXP(xpReward);
        exitArena.SetActive(true);
        scs.saveBossState(2);
    }

    public override void atDeath()
    {
        missionManager.deleteMission(missionCode);
    }
}
