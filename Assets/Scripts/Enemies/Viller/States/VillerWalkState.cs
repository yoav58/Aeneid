using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class VillerWalkState : StateMachineBehaviour
{
    Transform playerPlace;
    private Rigidbody2D rgd;
    public float speed;
    private VillerBoss villerMethods;
    public float attackRang;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       playerPlace = GameObject.FindGameObjectsWithTag("Player")[0].transform;
       if (playerPlace.name != "Agent")
       {
           playerPlace = playerPlace.transform.Find("Agent").transform;
       }
        //playerPlace = GameObject.FindGameObjectWithTag("Player").transform.Find("Agent").transform;
       // Debug.Log(playerPlace.gameObject.name);
       rgd = animator.GetComponent<Rigidbody2D>();
        villerMethods = animator.GetComponent<VillerBoss>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        villerMethods.LookAtPlayer();
        Vector2 target = new Vector2(playerPlace.position.x, rgd.position.y);
        Vector2 nextStep = Vector2.MoveTowards(rgd.position, target, speed * Time.deltaTime);
        rgd.MovePosition(nextStep);
        if (Vector2.Distance(playerPlace.position, rgd.position) <= attackRang)
        {
            animator.SetTrigger("Attack");
        }
    }
    
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
    {
        animator.ResetTrigger("Attack");
        animator.ResetTrigger("getHit");
    }


    private void checkNulls(Animator animator)
    {
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if(playerObject != null) 
            {
                Transform agentTransform = playerObject.transform.Find("Agent");
                if(agentTransform != null) 
                {
                    playerPlace = agentTransform;
                    Debug.Log(playerPlace.gameObject.name);
                }
                else 
                {
                    Debug.LogError("No GameObject named 'Agent' found as a child of 'Player'.");
                }
            } 
            else 
            {
                Debug.LogError("No GameObject with 'Player' tag found.");
            }

            rgd = animator.GetComponent<Rigidbody2D>();
            if(rgd == null) 
            {
                Debug.LogError("No Rigidbody2D component found on this GameObject.");
            }

            villerMethods = animator.GetComponent<VillerBoss>();
            if(villerMethods == null) 
            {
                Debug.LogError("No VillerBoss component found on this GameObject.");
            }
        }
    }
}
