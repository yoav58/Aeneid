using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsManager : MonoBehaviour
{

    public Skills[] skills;
    public Agent agent;
    

    public void ChangeSkill(int place,Skills newSkill)
    {
        skills[place] = newSkill;
    }
    // Start is called before the first frame update
    void Start()
    {
        agent.agentInput.onSkillCast = skills[0].skillAction;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setAgent(Agent a)
    {
        skills[0].setAgent(a);
    }

}
