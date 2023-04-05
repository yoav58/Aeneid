using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class DamageState : State
    {
        public HealthManager health;
        public IdleState idle;
        public SpriteRenderer playerSprite;
        public AgentAnimation animationManager;
        protected override void EnterState()
        {
            agent.agentAnimation.playAnimation(AnimationType.Damage);
            playerSprite.color = Color.red;
        }
        
       public void stopGetDamage()
        {
            animationManager.doSkillFalse();
            agent.transitionToOtherState(idle, this);
            playerSprite.color = Color.white;
        }
        }


    }

