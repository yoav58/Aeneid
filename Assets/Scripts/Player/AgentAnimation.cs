using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAnimation : MonoBehaviour
{
    private Animator animator;

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
            default:
                break;
        }
    }

}




public enum AnimationType
{
    Idle,
    Walk
}
