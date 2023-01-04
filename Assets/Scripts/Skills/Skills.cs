using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
abstract public class Skills : MonoBehaviour
{
    public Agent agent;
    public int SkillNumber;

    public void setAgent(Agent a)
    {
        this.agent = a;
    }


    public virtual void skillAction() { }

    public  abstract Sprite getSkillImage(int imageNumber);

    public abstract float getCoolDown();

    public abstract bool isCoolDown();

    public abstract void setIsCoolDown(bool coolDownState);
}
