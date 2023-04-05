using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public int health => _enemyBase.health;
    public int attack => _enemyBase.attack;
    public float speed => _enemyBase.speed;

    private float timer = 0f;

    private bool IsDamaging = false;
    private NavMeshAgent navMeshAgent;
    private BoxCollider2D boxCollider;


    #region Runtime
    private EnemyBase _enemyBase;
    private CharactorAI aiController;
    private PlayerController player; // TODO 不能new一个Mono
    #endregion
    
    // call Init before use, 把Enemy的属性存起来备用
    public void Init(EnemyBase enemyBase)
    {
        _enemyBase = enemyBase;
        aiController = GetComponent<CharactorAI>();
    }

    public void SetTarget(PlayerController playerController)
    {
        player = playerController;
        if (aiController != null)
        {
            aiController.SetNevTarget(playerController.transform);
        }
    }

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
                if (player != null)
                {
                    player.Injured(attack);
                }
                timer = 0f;
            }
        }
    }
}
