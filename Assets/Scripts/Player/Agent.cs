using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;
using UnityEngine.Serialization;

public class Agent : MonoBehaviour
{
    public Rigidbody2D rb2d;
    [FormerlySerializedAs("playerInput")] public PlayerInput agentInput;
    private Transform playerTransform;
    public float moveForce = 1f;
    public AgentAnimation agentAnimation;
    private AgentRender agentRender;
    public State currentState = null;
    public State previusState = null;
    public State[] states;
    // to see if the player dasing
    public HelperStateCheck helper;


    private void Awake()
    {
        agentInput = GetComponentInParent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        agentAnimation = GetComponentInChildren<AgentAnimation>();
        agentRender = GetComponentInChildren<AgentRender>();
        states = GetComponentsInChildren<State>();
        foreach(State s in states)
        {
            s.initializeState(this);
        }
    }
    private void Start()
    {
        agentInput.OnMovment += agentRender.ChangeAgentScale;
        transitionToOtherState(currentState, null);
    }



    /******************************************************************
     * Function Name: isStading
     *Description: this function check if the player is standing or not.
     *****************************************************************/
    public bool isStading()
    {
        if(Mathf.Abs(rb2d.velocity.x) < 0.1f)
        {
            return true;
        }
        return false;
    }


    /******************************************************************
    * Function Name: transitionToOtherState
    *Description: we want to move from one state to other
    *****************************************************************/

    public void transitionToOtherState(State newState, State olState)
    {
        if (newState == null) return;
        if (olState != null) olState.exit();
        previusState = olState;
        currentState = newState;
        currentState.Enter();
        
    }


    private void Update()
    {
        currentState.stateUpdate();
    }
    private void FixedUpdate()
    {
        currentState.stateFixedUpdated();
    }
}
