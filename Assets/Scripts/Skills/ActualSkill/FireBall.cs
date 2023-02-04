using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this class is the actual skill, the fireball himself.

public class FireBall : MonoBehaviour
{
    public float speed;
    private Animator animator;
    public Agent agent;
    public Transform place;
    private Rigidbody2D rigidBody;
    private Collider2D coll;
    public float damage;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        place = GetComponent<Transform>();
        agent = GameObject.Find("Agent").GetComponent<Agent>();
        rigidBody = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();


    }
    // Start is called before the first frame update
    void Start()
    {
        float xparent = agent.transform.localScale.x;
        if (agent.transform.localScale.x < 0)
        {
            place.localScale = new Vector3(place.localScale.x * xparent, place.localScale.y, place.localScale.z);
        }
        rigidBody.velocity = new Vector3(speed * xparent, rigidBody.position.y,0);
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item" || collision.tag == "Bound" || collision.tag == "Untagged") return;
        rigidBody.velocity = new Vector3(0, rigidBody.position.y, 0);
        animator.Play("HitExplosion", -1, 0);
        if(collision.tag == "Enemy") 
        {
           // Monster_First m = collision.gameObject.GetComponent<Monster_First>();
           DamageEnemy m = collision.gameObject.GetComponent<DamageEnemy>();
           // m.getDamage(damage);
           m.hitTheEnemy();
        }
        // it take time to Destroy object so Destroy the collider First.
        Destroy(coll);
    }

    public void killObject()
    {
        Destroy(gameObject);
    }
}
