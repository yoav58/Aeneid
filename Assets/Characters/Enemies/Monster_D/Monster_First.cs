using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_First : MonoBehaviour , Enemy
{
    int life;
    private Animator animator;


    public void getDamage()
    {
        animator.Play("demage", -1, 0f);
    }

    private void Awake()
    {
        animator =  GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
