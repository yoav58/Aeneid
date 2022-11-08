using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperStateCheck : MonoBehaviour
{
    int pressLeftCount;
    int pressRightCount;
    float Cooler;
    string lastPressed;

    private void Awake()
    {
        pressLeftCount = 0;
        pressRightCount = 0;
        Cooler = 0.5f;
    }


    /***************************************************
     * method Name:isRuning
     * Description: this function check if the user press
     * left arrow or right arrow twice.
     * *************************************************/
    protected bool isRuning(Rigidbody2D rb2d,string leftOrRight,ref int Counter)
    {
        if (Input.GetKeyUp(leftOrRight))
        {
            if(pressLeftCount == 0)
            {
                Counter = 1;
            }
            else
            {
                Counter = 0;
           
            }
            lastPressed = leftOrRight ;
            Cooler = 0.5f;
            return false;
        }

            if (Input.GetKeyDown(leftOrRight))
        {

            if (Cooler > 0 && Counter == 1 && string.Equals(leftOrRight,lastPressed))
            {
                return true;
            }
        }

        if (Cooler > 0)
        {

            Cooler -= 1 * Time.deltaTime;

        }
        else
        {
            Counter = 0;
        }
        return false;
    }

    public bool isRun(Rigidbody2D rb2d)
    {
        if (isRuning(rb2d, "left",ref pressLeftCount) || isRuning(rb2d, "right",ref pressRightCount)) return true;
        return false;
    }

}
