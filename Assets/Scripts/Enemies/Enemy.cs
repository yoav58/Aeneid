using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemy
{

    public virtual void getDamage(float damage){}
    public virtual void killMonster(){}


}


/*
 * script file that responsible for causing damage must have this method
 */
public interface DamageEnemyI
{
    public virtual void hitTheEnemy(float damage){}
}


public interface KillMonsterI
{
    public virtual void killMonster(){}
}
