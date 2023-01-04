using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkilllState : MonoBehaviour
{
    public SkillsManager m_sk;

    [Header("First Skill properties")]

    public Image firstSkill_image1;
    public Image firstSkill_image2;
    private float firstSkill_Cooldown;
    private bool firstSkill_NotStartSkill;


    // Start is called before the first frame update
    void Start()
    {
        setSkill1(); 

    }

    // Update is called once per frame
    void Update()
    {
        skill1StateUpdate();
    }


    // set the the skill values.
    private void setSkill1()
    {
        firstSkill_image1.sprite = m_sk.skills[0].getSkillImage(1);
        firstSkill_image2.sprite = m_sk.skills[0].getSkillImage(2);
        firstSkill_Cooldown = m_sk.skills[0].getCoolDown();
        firstSkill_image2.fillAmount = 0;


    }


    /******************************************************************
    * Function Name: skill1StateUpdate
    *Description: this metod is check if in cool down state, if so
    *start cooldown animation.
    *****************************************************************/
    private void skill1StateUpdate()
    {
        if (m_sk.skills[0].isCoolDown() && firstSkill_NotStartSkill == false)
        {
            firstSkill_image2.fillAmount = 1;
            firstSkill_NotStartSkill = true;
        } else if (m_sk.skills[0].isCoolDown())
        {
            firstSkill_image2.fillAmount -= 1 / firstSkill_Cooldown * Time.deltaTime;
            if(firstSkill_image2.fillAmount <= 0)
            {
                firstSkill_NotStartSkill = false;
                m_sk.skills[0].setIsCoolDown(false); // when finish the animation let the player use the skill.
            }
        }
    }
}