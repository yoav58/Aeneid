using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentRender : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform parentTransform;

    private void Awake()
    {
        //parentTransform = transform.parent;
    }
/******************************************************************
* Function Name: HandleMovement
*Description: This function change the player scale .
*****************************************************************/
    public void ChangeAgentScale(Vector2 playerVector)
    {
        if(playerVector.x > 0)
        {
            transform.parent.localScale = new Vector3(1, transform.parent.localScale.y, transform.parent.localScale.z);
        }
        else if(playerVector.x < 0)
        {
            transform.parent.localScale = new Vector3(-1, transform.parent.localScale.y, transform.parent.localScale.z);
       }
    }
}
