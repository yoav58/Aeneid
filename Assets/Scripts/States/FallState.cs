using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class FallState : WalkState
{
    public float fallSpeed = 0.5f;




    protected override void EnterState()
    {
        agent.agentAnimation.playAnimation(AnimationType.Fall);
        
    }

    protected override void handleJump()
    {
       // dont allow jump
    }

    public override void stateUpdate()
    {
        movmentData.currentVelocity = agent.rb2d.velocity;
        movmentData.currentVelocity.y += fallSpeed * Physics2D.gravity.y * Time.deltaTime;
        agent.rb2d.velocity = movmentData.currentVelocity;
        CalcualateVelocity();
        SetPlayerVelocity();

        if (agent.groundDetector.isGrounded) agent.transitionToOtherState(idleState, this);
    }
}


