using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePatrol : MonoBehaviour
{
    [Header("Patrol Points")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    
    [Header("Enemy")]
    [SerializeField] private Transform enemy;
    
    [Header("Movement parameters")]
    [SerializeField] private float speed;
    private Vector3 initScale;
    public bool movingLeft = false;

    [Header("Idle Behaviour")]
    [SerializeField] private float idleDuration;
    private float idleTimer;
    
    [Header("Enemy Animator")]
    [SerializeField] private Animator anim;
    
    public Transform player;
    private bool playerIsTheLimit = false;

    public bool firstMoveLeft = true;
    
    private void Awake()
    {
        initScale = enemy.localScale;
    }
    
    private void OnDisable()
    {
        anim.SetBool("Walk", false);
    }
    private void Update()
    {
        if (movingLeft)
        {
            if (enemy.position.x >= leftEdge.position.x)// if not touch the edge
                MoveInDirection(-1);
            else
                DirectionChange();
        }
        else
        {
            if (enemy.position.x <= rightEdge.position.x) 
                MoveInDirection(1);
            else
                DirectionChange();
        }
        
            
    }

    private void FixedUpdate()
    {
        if (!playerIsTheLimit)
        {
            float playerPositionX = player.position.x;
            if (playerPositionX >= leftEdge.position.x && playerPositionX <= rightEdge.position.x)
            {
                rightEdge = leftEdge = player;
                playerIsTheLimit = true;
                idleDuration = 0.5f;
            }
        }
    }

    private void DirectionChange()
    {
        anim.SetBool("Walk", false);
        idleTimer += Time.deltaTime;

        if (idleTimer > idleDuration)
            movingLeft = !movingLeft;
    }

    private void MoveInDirection(int _direction)
    {
        idleTimer = 0;
        anim.SetBool("Walk", true);

        int facingDirection = movingLeft ? -1 : 1;
        //Make enemy face direction
        enemy.localScale = new Vector3(Mathf.Abs(initScale.x) * facingDirection,
            initScale.y, initScale.z);

        //Move in that direction
        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * _direction * speed,
            enemy.position.y, enemy.position.z);
    }
}
