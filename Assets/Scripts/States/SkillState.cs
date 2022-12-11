using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class SkillState : State
    {

        public State idleState;
        public SkillsManager skillManager;

        protected override void EnterState()
        {
            skillManager.setAgent(agent);
            skillManager.skills[0].skillAction();
        }

        public override void stateUpdate()
        {
            if (!agent.agentAnimation.doingSkill())
            {
                agent.transitionToOtherState(idleState, this);
            }
        }

        protected override void ExitState()
        {
            agent.agentInput.onSkillCast = null;

        }
    }
}