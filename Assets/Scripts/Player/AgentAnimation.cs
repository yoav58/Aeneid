using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    private Animation animation;
    private Animator animator;
    bool DoingSkill = false;
    public States.DamageState damageState;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /******************************************************************
    * Function Name: changeAnimation
    *Description: this function change the animation to the input animation.
    *****************************************************************/
    private void changeAnimation(string animationName)
    {
        animator.Play(animationName,-1,0f);
    }
    /******************************************************************
   * Function Name: playAnimation
   *Description: this function will be public for the parent class to
   *control the animation
   *****************************************************************/
    public void playAnimation(AnimationType animation)
    {
        switch (animation)
        {
            case AnimationType.Idle:
                changeAnimation("Idle");
                break;
            case AnimationType.Walk:
                changeAnimation("Walk");
                break;
            case AnimationType.Run:
                changeAnimation("Run");
                break;
            case AnimationType.Jump:
                changeAnimation("Jump");
                break;
            case AnimationType.Fall:
                changeAnimation("Fall");
                break;
            case AnimationType.FireBall:
                changeAnimation("FireBallSkill");
                break;
            case AnimationType.Damage:
                changeAnimation("damage");
                break;
            case AnimationType.Pause:
                changeAnimation("Pause");
                break;
            default:
                break;
        }
    }


    // for animation Events
    public void doSkillTrue()
    {
        DoingSkill = true;
    }

    public void doSkillFalse()
    {
        DoingSkill = false;
    }

    public bool doingSkill()
    {
        return this.DoingSkill;
    }

    public void stopDamage()
    {
        damageState.stopGetDamage();
    }


}



public enum AnimationType
{
    Idle,
    Walk,
    Run,
    Jump,
    Fall,
    FireBall,
    Damage,
    Pause
}
