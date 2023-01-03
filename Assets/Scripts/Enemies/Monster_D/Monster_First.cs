using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_First : MonoBehaviour , Enemy
{
    private Animator animator;
    private EnemyLifeBar lifeBar;
    public GameObject b;
    public Transform placeCoin;
    public ExpManager playerXP;
    public float xpReward;


    public void getDamage(float damage)
    {
        animator.Play("demage", -1, 0f);
        lifeBar.reduceLife(damage);
    }

    private void Awake()
    {
        animator =  GetComponent<Animator>();
        lifeBar = GetComponentInChildren<EnemyLifeBar>();
    }


    // Start is called before the first frame update
    void Start()
    {
        lifeBar.setMonster(gameObject);       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
;
    }

    public void killMonster()
    {
        playerXP.addXP(xpReward);
        Instantiate(b, placeCoin.position, placeCoin.rotation);
    }
}
