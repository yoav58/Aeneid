using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerFireSkill : Skills
{
    public Transform lazerFirePlace;
    public GameObject projectile;
    public float cooldown;
    public string skillName = "LazerFire";
    public Sprite im1;
    public Sprite im2;
    public bool _isCoolDown = false;
    // Start is called before the first frame update
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
    
    public override void skillAction()
    {
        if (_isCoolDown) return;
        agent.agentAnimation.playAnimation(AnimationType.FireBall);
        _isCoolDown = true;
        Instantiate(projectile, lazerFirePlace.position,lazerFirePlace.rotation);
    }
}
