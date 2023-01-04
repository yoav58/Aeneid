using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header("Attack Parameters")]
    [Range(0, 10)] public float attackCooldown;
    [Range(0, 100)] public float range;
    [Range(0, 100)] public int damage;

    [Header("Collider Parameters")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private Collider2D boxCollider;

    [Header("Player Layer")]
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    public  HealthManager healthManager; // the player healthManager;
    private Animator anim;
    public bool isHit = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer += Time.deltaTime;

        //Attack only when player in sight?
        if (PlayerInSight())
        {
            attack();
        }
    }
    /******************************************************************
    * Function Name: PlayerInSight
    *Description: this function check if ther player is close to the enemy.
    *return yes if so.
    *****************************************************************/
    private bool PlayerInSight()
    {
        RaycastHit2D hit =
            Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, playerLayer);

        //if (hit.collider != null)
        //  playerHealth = hit.transform.GetComponent<Health>();
        if (hit.collider != null && hit.collider.tag == "Player") return true;
        return false;    //return hit.collider.tag != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }

    private void attack()
    {
        if (cooldownTimer >= attackCooldown)
        {
            cooldownTimer = 0;
            anim.Play("attack_02", -1, 0);
        }
    }


    private void damagePlayer()
    {
        if (PlayerInSight())
        {
            Debug.Log("insight");
            healthManager.reduceHealth(damage);
        }
    }


}
