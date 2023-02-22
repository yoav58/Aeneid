using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireBallSKill : Skills
{
    public Transform fireBallPlace;
    public GameObject projectile;
    public float cooldown;
    public string skillName = "FireBall";
    public Sprite im1;
    public Sprite im2;
    public bool _isCoolDown = false;






    public override float getCoolDown()
    {
        return cooldown;
    }

    public override Sprite getSkillImage(int imageNumber)
    {
        if (imageNumber == 1) return im1;
        return im2;
    }

    public override bool isCoolDown()
    {
        return _isCoolDown;
    }

    public override void setIsCoolDown(bool coolDownState)
    {
        _isCoolDown = coolDownState;
    } 

 /******************************************************************
* Function Name: skillAction
*Description: this function do the Fire Ball Skill.
*firt animate then create the fireBall object.
*****************************************************************/
    public override void skillAction()
    {
        if (_isCoolDown) return;
        agent.agentAnimation.playAnimation(AnimationType.FireBall);
        _isCoolDown = true;
        Instantiate(projectile, fireBallPlace.position,fireBallPlace.rotation);
    }

}
