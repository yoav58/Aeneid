using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class JumpState : WalkState
{
    [Range(0, 20)]
    public float JumpForce = 12f;
    public float jumperPhysicsForce = 2;
    private bool Jumping;
    protected override void EnterState()
    {
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
