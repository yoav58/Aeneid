using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class JumpState : WalkState
{
    [Range(0, 20)]
    public float JumpForce = 12f;
    [Range(0, 20)]
    public float jumperPhysicsForce = 2;
    private bool Jumping;
    public SpriteRenderer playerSprite;

    protected override void EnterState()
    {
        playerSprite.color = Color.white;
        agent.agentAnimation.playAnimation(AnimationType.Jump);
        movmentData.currentVelocity = agent.rb2d.velocity;
        movmentData.currentVelocity.y = JumpForce;
        agent.rb2d.velocity = movmentData.currentVelocity;
        Jumping = true;
    }
    protected override void handleJump()
    {
        Jumping = true;
    }

    protected override void handleStopJump()
    {
        Jumping = false;
    }
    /**********************************************************************
   * Method Name: stateUpdate
   * description: here we calculate the jump force 
   ***********************************************************************/
    public override void stateUpdate()
    {
        JumpHeight();
        CalcualateVelocity();
        SetPlayerVelocity();
        if(agent.rb2d.velocity.y <= 0) // start falling
        {
            agent.transitionToOtherState(FallState, this);
        }
    }
    /**********************************************************************
    * Method Name: JumpHeight
    * description: if we stop jump we want to fall faster.
    ***********************************************************************/
    private void JumpHeight()
    {
        if(Jumping == false)
        {
            movmentData.currentVelocity = agent.rb2d.velocity;
            movmentData.currentVelocity.y += jumperPhysicsForce *Physics2D.gravity.y * Time.deltaTime;
            agent.rb2d.velocity = movmentData.currentVelocity;
        }
    }
}
