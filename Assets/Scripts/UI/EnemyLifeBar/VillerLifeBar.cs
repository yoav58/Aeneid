using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillerLifeBar: MonoBehaviour
{
    Transform life;
    bool isDead = false;
    GameObject monster;
    public GameObject d;
    public DamageEnemy m;

    private void Awake()
    {
        life = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    public void reduceLife(float damage)
    {
        Transform lifeBar = life.Find("HpBar");
        if (lifeBar.localScale.x - damage > 0) { lifeBar.localScale = new Vector3(lifeBar.localScale.x - damage, lifeBar.localScale.y, lifeBar.localScale.z);
        }else
        {
            lifeBar.localScale = new Vector3(0, lifeBar.localScale.y, lifeBar.localScale.z);

            m.killMonster();
            Destroy(d);
            //Destroy(monster);
            
        }


    }

    public void setMonster(GameObject o)
    {
        monster = o;
    }

    
}