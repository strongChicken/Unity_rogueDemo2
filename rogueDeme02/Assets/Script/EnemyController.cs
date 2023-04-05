using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public int health = 10;
    public int attack = 2;
    public float speed = 5.0f;

    private float timer = 0f;

    private bool IsDamaging = false;
    private NavMeshAgent navMeshAgent;
    private BoxCollider2D boxCollider;

    private PlayerController player = new PlayerController();

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            IsDamaging = true;
            DamageCheck();
            //Debug.Log("IsDamaging " + IsDamaging);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            IsDamaging = false;
            Debug.Log("IsDamaging "+IsDamaging);
        }
    }

    private void DamageCheck()
    {
        if (IsDamaging)
        {
            timer += Time.deltaTime;
            Debug.Log("timer "+ timer);

            if (timer >= 1.0f)
            {
                Debug.Log("造成1次伤害");
                player.Injured(attack);
                timer = 0f;
            }
        }
    }
}
