using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public bool moveUpDown;
    public bool moveRightLeft;
    [Header("Patrol Points")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    [SerializeField] private Transform upEdge;
    [SerializeField] private Transform downEdge;
    private bool movingLeft = false;
    private bool movingUp = false;
    
    //[Header("Platform")]
     private Transform platform;
    
    [Header("Movement parameters")]
    [SerializeField] private float speed;
    private Vector3 initScale;

    // how much time wait before walk again
    [Header("Wating Time")]
    [SerializeField] private float idleDuration;
    private float idleTimer;


    private void Awake()
    {
        platform = gameObject.GetComponent<Transform>();
    }
    
    private void DirectionChange()
    {
        idleTimer += Time.deltaTime;
        if (idleTimer > idleDuration)
        {
            if (moveRightLeft == true) movingLeft = !movingLeft;
            else movingUp = !movingUp;
        }
    }
    
    private void MoveInDirection(int _direction)
    {
        idleTimer = 0;
        
        //Move in that direction
        if(moveRightLeft) RightOrLeft(_direction);
        else UpOrDown(_direction);
    }

    private void RightOrLeft(int direction)
    {
        platform.position = new Vector3(platform.position.x + Time.deltaTime * direction * speed,
            platform.position.y, platform.position.z);
    }

    private void UpOrDown(int direction)
    {
        platform.position = new Vector3(platform.position.x ,
            platform.position.y + Time.deltaTime * direction * speed, platform.position.z);
    }

    private void movingRightOrLeftMethod()
    {
        if (movingLeft)
        {
            if (platform.position.x >= leftEdge.position.x)// if not touch the edge
                MoveInDirection(-1);
            else
                DirectionChange();
        }
        else
        {
            if (platform.position.x <= rightEdge.position.x) 
                MoveInDirection(1);
            else
                DirectionChange();
        }
    }

    private void movingUpDownMethod()
    {
        if (movingUp)
        {
            if (platform.position.y <= upEdge.position.y)// if not touch the edge
                MoveInDirection(1);
            else
                DirectionChange();
        }
        else
        {
            if (platform.position.y >= downEdge.position.y) 
                MoveInDirection(-1);
            else
                DirectionChange();
        }
    }

    private void Update()
    {
        if(moveRightLeft) movingRightOrLeftMethod();
        else movingUpDownMethod();
    }
}



