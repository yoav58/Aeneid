using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider slider;
    public Agent agent;
    public States.DamageState damageState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reduceHealth(float hitPower)
    {
        agent.transitionToOtherState(damageState, agent.currentState);
        slider.value -= hitPower;
        if (slider.value - hitPower < 0) slider.value = 0;

        
    }
}
