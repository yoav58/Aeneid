using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemy
{

    public void getDamage(float damage) {}
    

}


public interface IEnemyDamage
{
    public virtual void hitTheEnemy(float damage){}
}
