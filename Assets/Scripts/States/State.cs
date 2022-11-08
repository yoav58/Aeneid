using UnityEngine;
using UnityEngine.Events;

namespace States
{
    public abstract class State : MonoBehaviour
    {
        protected Agent agent;
        public UnityEvent OnEnter, OnExit; // probally when enter the state we got a lot of things to do


        /**********************************************************************
        * Method Name: initializeState
        * description: initialize the state to the currect agent.
        ***********************************************************************/
        public void initializeState(Agent a)
        {
            agent = a;
        }


        /**********************************************************************
        * Method Name: Enter
        * description: when we enter the state, do all the functionality we want to do.
        * and invoke all the method of our enter event.
        ***********************************************************************/
        public void Enter()
        {
            agent.agentInput.OnMovment += handleMovement;
            OnEnter?.Invoke();
            EnterState();

        }
        /**********************************************************************
        * Method Name: EnterState 
        * description: what the class will actually do when he became active.
        ***********************************************************************/
        protected abstract void EnterState();


        /**********************************************************************
        * Method Name: handleMovement 
        * description: will function as used by the agent when movment is happaned.
        ***********************************************************************/
        protected virtual void handleMovement(Vector2 o) { }


    /**********************************************************************
    * Method Name: stateUpdate 
    * description: will function as MonoBehaviour.Update.
    ***********************************************************************/
        public virtual void stateUpdate()
        {
        }


     /**********************************************************************
     * Method Name: stateFixedUpdated
     * description: will function as MonoBehaviour.FixedUpdate.
     ***********************************************************************/
        public virtual void stateFixedUpdated() { }

    
    /**********************************************************************
    * Method Name: exit
    * description: same as enter, but the opposite.
     ***********************************************************************/
        public void exit()
        {
            agent.agentInput.OnMovment -= handleMovement;
            OnExit.Invoke();
            ExitState();
        }


     /**********************************************************************
     * Method Name: ExitState
     * description: what actually this class will do when exit.
     ***********************************************************************/
        protected virtual void ExitState()
        {
        
        }
    }
}
