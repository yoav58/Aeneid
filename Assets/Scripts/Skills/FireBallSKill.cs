using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSKill : Skills
{
    public Transform fireBallPlace;
    public GameObject projectile;


    public override void skillAction()
    {
        Debug.Log("shoot");
        agent.agentAnimation.playAnimation(AnimationType.FireBall);
        Debug.Log(fireBallPlace.rotation);
        Instantiate(projectile, fireBallPlace.position,fireBallPlace.rotation);
    }

}
