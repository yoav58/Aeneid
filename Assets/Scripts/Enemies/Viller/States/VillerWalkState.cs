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
        playerPlace = GameObject.FindGameObjectsWithTag("Player")[1].transform;
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
}
