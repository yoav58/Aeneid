using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [field:SerializeField]
    public AgentAnimation agentAnimation;
    public Vector2 MovmentVector  { get; private set;}
    // we want to pass method to each Event.
    public event Action OnAttack, OnJumpPresset, OnJumpReleased, OnWeaponChange;
    // i prefered that skills will be in delegate and not event.
    public delegate void SkillDelegate();
    public SkillDelegate onSkillCast;
    // when move
    public event Action<Vector2> OnMovment,OnRunning;
    // assign the controllers
    public KeyCode jumpKey, attacKey, menuKey,swapSkill, firstSkill;
    public UnityEvent OnMenuKeyPressed;
    public bool doSkill = true;


    private void Update()
    {
        if(Time.timeScale > 0)
        {
            getMovmentInput();
            getJumptInput();
            getAttackInput();
            getWeaponSwapInput();
            getFirstSkillInput();
        }
        getMenuInput();
       
    }

    /* the upcoming methods if to ivoke all the events we created for input situations.
     * those methods will used in update function to check every time the user enter a input.
     */

    private void getWeaponSwapInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnWeaponChange?.Invoke();
        }
    }

    private void getAttackInput()
    {
        if (Input.GetKeyDown(attacKey))
        {
            OnAttack?.Invoke();
        }
    }

    private void getMenuInput()
    {
        if (Input.GetKeyDown(menuKey))
            if (!agentAnimation.doingSkill())
            {
            OnMenuKeyPressed?.Invoke();
        }
    }

    private void getJumptInput()
    {
        if (Input.GetKeyDown(jumpKey))
            if (!agentAnimation.doingSkill())
            {
            OnJumpPresset?.Invoke();
        }
        if (Input.GetKeyUp(jumpKey))
            if (!agentAnimation.doingSkill())
            {
            OnJumpReleased?.Invoke();
        }
    }

    private void getMovmentInput()
    {
            MovmentVector = getMovmentVector();
            OnMovment?.Invoke(MovmentVector);
    }

    private void getFirstSkillInput()
    {
        if (Input.GetKeyDown(firstSkill))
            if(!agentAnimation.doingSkill())
        {
                onSkillCast?.Invoke();
        }
    }

    private Vector2 getMovmentVector()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }





}
