using UnityEngine;

namespace States
{
    public class IdleState : State
    {
        public State walkState,runState;
        protected override void EnterState()
        {

            agent.agentAnimation.playAnimation(AnimationType.Idle);
            // play idleAnimation
        }
        public override void stateUpdate()
        {
            
            if (agent.helper.isRun(agent.rb2d))
            {
                agent.transitionToOtherState(runState, this);
            }
        }
        protected override void handleMovement(Vector2 input)
        {
            // when the user pressed right or left key, transition to walk.
            if (Mathf.Abs(input.x) > 0.1f)
            {
                agent.transitionToOtherState(walkState, this);
            }
        }
    }
}
