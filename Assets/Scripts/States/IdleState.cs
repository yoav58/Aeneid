using UnityEngine;

namespace States
{
    public class IdleState : State
    {
        public State walkState;
        protected override void EnterState()
        {
            agent.agentAnimation.playAnimation(AnimationType.Idle); // play idleAnimation
        }

        protected override void handleMovement(Vector2 input)
        {
            // when the user pressed right or left key, transition to walk.
            if (Mathf.Abs(input.x) > 0)
            {
                agent.transitionToOtherState(walkState, this);
            }
        }
    }
}
