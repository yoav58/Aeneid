using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RameroHitMethod : EnemyMethods, IEnemyDamage
{
    public  float Defence;
    private EnemyLifeBar lifeBar;
    private Animator anim;
    public bool isInDefence;
    public ExpManager playerXP;
    public float xpReward;
    public GameObject exitArena;
    public SceneSaver scs;
    public int missionCode;
    public MissionScript missionManager;
    public missionsFinishedManager missionFinish;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        lifeBar = GetComponentInChildren<EnemyLifeBar>();

    }

    // Start is called before the first frame update
    public override void killMonster()
    {
        playerXP.addXP(xpReward);
        exitArena.SetActive(true);
        scs.saveBossState(2);
        
    }

    public virtual void hitTheEnemy(float damage)
    {
        if(!isInDefence){ 
        anim.SetTrigger("getHit");
        damage = damage * ( (100-Defence) / 100);
        lifeBar.reduceLife(damage);
        }
        else anim.SetTrigger("StopShield");


    }

    public void setIsDefence(bool b)
    {
        isInDefence = b;
    }

    public override void atDeath()
    {
        missionManager.deleteMission(missionCode);
        if(missionFinish != null) missionFinish.finishedMission();

    }
}
