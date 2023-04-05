using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public int health = 10;
    public int attack = 2;
    public float speed = 5.0f;

    private bool IsDamaging;
    private NavMeshAgent navMeshAgent;
    private BoxCollider2D boxCollider;

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
            Debug.Log("IsDamaging " + IsDamaging);
            StartCoroutine(ApplyDamage());
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


    IEnumerator ApplyDamage()
    {
        while (IsDamaging)
        {
            yield return new WaitForSeconds(1.0f);
            PlayerController player = FindObjectOfType<PlayerController>();
            player.Injured(attack);
        }
    }
}
