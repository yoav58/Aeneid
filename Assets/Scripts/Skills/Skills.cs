using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public Agent agent;
    public int SkillNumber;

    public void setAgent(Agent a)
    {
        this.agent = a;
    }


    public virtual void skillAction() { }

}
