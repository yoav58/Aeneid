using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider slider;
    public Agent agent;
    public States.DamageState damageState;
    public StatesLoader stl;
    // Start is called before the first frame update
    void Start()
    {
        if (stl.has_load_Health()) slider.value = stl.LoadHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // reduce the health 
    public void reduceHealth(float hitPower)
    {
        agent.transitionToOtherState(damageState, agent.currentState);
        slider.value -= hitPower;
        if (slider.value - hitPower < 0) slider.value = 0;
    }

    public float getHealth() { return slider.value; }

    public void addLife(float lifeAdding)
    {
        float newVal = slider.value + lifeAdding;
        if (newVal > 100) newVal = 100;
        slider.value = newVal;
        Debug.Log(newVal);
        Debug.Log(slider.value);
    }
}
