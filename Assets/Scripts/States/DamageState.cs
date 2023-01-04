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
        protected override void EnterState()
        {
            agent.agentAnimation.playAnimation(AnimationType.Damage);
            playerSprite.color = Color.red;
        }
        
       public void stopGetDamage()
        {
            agent.transitionToOtherState(idle, this);
            playerSprite.color = Color.white;
        }
        }


    }

