using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class SkillState : State
    {

        public State idleState;
        public SkillsManager skillManager;
        public AgentAnimation agn;

        protected override void EnterState()
        {
            skillManager.setAgent(agent);
            skillManager.doCurrentSkill();
            agn.doSkillTrue();
            
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