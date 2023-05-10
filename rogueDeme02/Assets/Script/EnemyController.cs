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

    #region Runtime
    private EnemyBase _enemyBase;
    private CharactorAI aiController;
    private PlayerController player;
    #endregion

    private bool IsDamaging = false;
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

    public void Init(EnemyBase enemyBase)
    {
        _enemyBase = enemyBase; // TODO _enemyBase干嘛用的
        aiController = GetComponent<CharactorAI>(); // TODO aiController干嘛用的
    }

    // 设置敌人的Nav目标
    // 1. 获取playerController
    // 2. 将player的transform传给敌人身上的Nav
    public void SetTarget(PlayerController playerController)
    {
        player = playerController;
        if (player != null)
        {
            aiController.setNavTarget(player.transform);
            Debug.Log("setNavTarget is ok");
        }
        Debug.Log("====SetTarget is null====");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            IsDamaging = true;
            DamageCheck();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            IsDamaging = false;
        }
    }

    private void DamageCheck()
    {
        if (IsDamaging)
        {
            timer += Time.deltaTime;
            if (timer >= 1.0f)
            {
                if (player != null)
                {
                    Debug.Log("造成1次伤害");
                    player.Injured(attack);
                    timer = 0f;
                }
            }
        }
    }

}
