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
    
    [Header("Second Skill properties")]
    
    public Image secondSkill_image1;
    public Image secondSkill_image2;
    private float secondSkill_Cooldown;
    private bool secondSkill_NotStartSkill;
    
    [Header("Third Skill properties")]
    public Image thirdSkill_image1;
    public Image thirdSkill_image2;
    private float thirdSkill_Cooldown;
    private bool thirdSkill_NotStartSkill;
    

    // Start is called before the first frame update
    void Start()
    {
        setSkill1(); 
        setSkill2();
        setSkill3();

    }

    // Update is called once per frame
    void Update()
    {
        skill1StateUpdate();
        skill2Update();
        skill3Update();
    }


    // set the the skill values.
    private void setSkill1()
    {
        firstSkill_image1.sprite = m_sk.skills[0].getSkillImage(1);
        firstSkill_image2.sprite = m_sk.skills[0].getSkillImage(2);
        firstSkill_Cooldown = m_sk.skills[0].getCoolDown();
        firstSkill_image2.fillAmount = 0;


    }

    public void setSkill2()
    {
        secondSkill_image1.sprite = m_sk.skills[1].getSkillImage(1);
        secondSkill_image2.sprite = m_sk.skills[1].getSkillImage(2);
        secondSkill_Cooldown = m_sk.skills[1].getCoolDown();
        secondSkill_image2.fillAmount = 0;
    }

    public void setSkill3()
    {
        thirdSkill_image1.sprite = m_sk.skills[2].getSkillImage(1);
        thirdSkill_image2.sprite = m_sk.skills[2].getSkillImage(2);
        thirdSkill_Cooldown = m_sk.skills[2].getCoolDown();
        thirdSkill_image2.fillAmount = 0;
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

    private void skill2Update()
    {
        if (m_sk.skills[1].isCoolDown() && secondSkill_NotStartSkill == false)
        {
            secondSkill_image2.fillAmount = 1;
            secondSkill_NotStartSkill = true;
        } else if (m_sk.skills[1].isCoolDown())
        {
            secondSkill_image2.fillAmount -= 1 / secondSkill_Cooldown * Time.deltaTime;
            if(secondSkill_image2.fillAmount <= 0)
            {
                secondSkill_NotStartSkill = false;
                m_sk.skills[1].setIsCoolDown(false); // when finish the animation let the player use the skill.
            }
        }
    }

    private void skill3Update()
    {
        if (m_sk.skills[2].isCoolDown() && thirdSkill_NotStartSkill == false)
        {
            thirdSkill_image2.fillAmount = 1;
            thirdSkill_NotStartSkill = true;
        } else if (m_sk.skills[2].isCoolDown())
        {
            thirdSkill_image2.fillAmount -= 1 / thirdSkill_Cooldown * Time.deltaTime;
            if(thirdSkill_image2.fillAmount <= 0)
            {
                thirdSkill_NotStartSkill = false;
                m_sk.skills[2].setIsCoolDown(false); // when finish the animation let the player use the skill.
            }
        }
    }
    
    }