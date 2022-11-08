using System;
using UnityEngine;

namespace States
{
    public class WalkState : State
    {
        public State idleState,runState;
        public MovmentData movmentData; // this file for public acess to movment data
        public float acceleration, maxSpeed, deacceleration;
        private int buttonCount;
        public float  buttonCooler;

        private void Awake()
        {
            movmentData = GetComponentInParent<MovmentData>();
        }

        protected override void EnterState()
        {
            agent.agentAnimation.playAnimation(AnimationType.Walk);
            // promise us that we start from idle
            movmentData.horizontalMovmentDirection = 0;
            movmentData.currentSpeed = 0;
            movmentData.currentVelocity = Vector2.zero;
        }


        public  override void stateUpdate()
        {
            // check if the player is runing.
            if (agent.helper.isRun(agent.rb2d)) agent.transitionToOtherState(runState, this);
            base.stateUpdate();
            CalcualateVelocity(); // first we calculate the player velocity it should have 
            SetPlayerVelocity(); // set the velocity we calculated
            if (agent.isStading()) agent.transitionToOtherState(idleState, this);

        } 
 /**********************************************************************
 * Method Name: calcualateVelocity
 * description: here we calcula
 ***********************************************************************/
        private void CalcualateVelocity()
        {
            CalculateSpeed(agent.agentInput.MovmentVector, movmentData);
            CalculateHorizontalDirection(movmentData);
            movmentData.currentVelocity = Vector3.right * movmentData.horizontalMovmentDirection * movmentData.currentSpeed;
            movmentData.currentVelocity.y = agent.rb2d.velocity.y;
        }
 /**********************************************************************
 * Method Name: calculateSpeed
 * description: ctrate effect of accelartion, if the player start the run/stop
 * the speed while increase/decrease by the accleration/deccleration.
 ***********************************************************************/
        private void CalculateSpeed(Vector2 agentMovment, MovmentData movementData)
        {
            if (Mathf.Abs(agentMovment.x) > 0)
            {
                movementData.currentSpeed += maxSpeed;//acceleration * Time.deltaTime;
            
            }
            else
            {
                movementData.currentSpeed = 0;//deacceleration * Time.deltaTime;
            }

            movementData.currentSpeed = Math.Clamp(movementData.currentSpeed, 0, maxSpeed);
        }
 /**********************************************************************
 * Method Name: calculateHorizontalDirection
 * description: want to know what is the player face left or right.
 ***********************************************************************/
        private void CalculateHorizontalDirection(MovmentData movmentData1)
        {
            if (agent.agentInput.MovmentVector.x > 0)
            {
                movmentData1.horizontalMovmentDirection = 1;
            }else if (agent.agentInput.MovmentVector.x < 0) movmentData1.horizontalMovmentDirection = -1;
        } 
        /**********************************************************************
    * Method Name: setPlayerVelocity
    * description: set the agent velocity to the movmentData fields.
    ***********************************************************************/
        private void SetPlayerVelocity()
        {
            agent.rb2d.velocity = movmentData.currentVelocity;
        }
    

    }
}
