using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSKill : Skills
{
    public Transform fireBallPlace;
    public GameObject projectile;


    /******************************************************************
   * Function Name: skillAction
   *Description: this function do the Fire Ball Skill.
   *firt animate then create the fireBall object.
   *****************************************************************/
    public override void skillAction()
    {
        Debug.Log("shoot");
        agent.agentAnimation.playAnimation(AnimationType.FireBall);
        Debug.Log(fireBallPlace.rotation);
        Instantiate(projectile, fireBallPlace.position,fireBallPlace.rotation);
    }

}
