using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundDetector : MonoBehaviour
{
    public Collider2D agentCollider; // the collider of the player
    public LayerMask groundMask; // 
    public bool isGrounded; // we need to know if we Grounded


    // those fields is to easy resize the boxCollider(Ground) of the character
    [Header("Game")]
    [Range(-2f, 2f)]
    public float boxCastYoffset = -0.1f;

    [Range(-2f, 2f)]
    public float boxCastxoffset = -0.1f;


    [Range(0, 2)]
    public float BoxCastWidth = 1;

    public float BoxCastHeight = 1;


    public Color gizmoColorNotCollide = Color.red;
    public Color gizmoColorCollide = Color.green;

    private void Awake()
    {
        if(agentCollider == null)
        {
            agentCollider = GetComponent<Collider2D>();
        }
    }


    /******************************************************************
    * Function Name: OnDrawGizmos
    *Description: simply draw Gizmo (for debug)
    *****************************************************************/
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColorNotCollide;
        if (isGrounded) Gizmos.color = gizmoColorCollide;
        Vector3 center = agentCollider.bounds.center + new Vector3(boxCastxoffset, boxCastYoffset, 0);
        Vector3 size = new Vector3(BoxCastWidth, BoxCastHeight, 0);
        Gizmos.DrawWireCube(center, size);
    }

    /******************************************************************
   * Function Name: CheckIfGrounded
   *Description: This method check if the player is touch the ground
   *****************************************************************/
    public void CheckIfGrounded()
    {

        RaycastHit2D boxrayCast = Physics2D.BoxCast(getOrigin(), getSize(), 0, Vector2.down, 0, groundMask);
        if (boxrayCast.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    private Vector3 getOrigin()
    {
        return agentCollider.bounds.center + new Vector3(boxCastxoffset, boxCastYoffset, 0);
    }
    private Vector2 getSize()
    {
        return new Vector2(BoxCastWidth, BoxCastHeight);
    }

}
