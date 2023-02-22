using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsManager : MonoBehaviour
{

    public Skills[] skills;
    public Agent agent;
    private int currentSkillIndex;
    

    public void ChangeSkill(int place,Skills newSkill)
    {
        skills[place] = newSkill;
    }
    // Start is called before the first frame update
    void Start()
    {
        //agent.agentInput.onSkillCast = skills[0].skillAction;
        //agent.agentInput.secondSkillCast = skills[1].skillAction;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setAgent(Agent a)
    {
        skills[0].setAgent(a);
    }

    public void currentSkill(int index)
    {
        currentSkillIndex = index;
    }

    public void doCurrentSkill()
    {
        skills[currentSkillIndex].skillAction();
    }

}
