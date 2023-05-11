using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyBase
{
    public int speed = 0;
    public int power = 0;
    public int attack = 0;
    public int health = 0;
    public int defend = 0;
    public int critical = 0;

    public GameObject gameObject { get; }
    private EnemyController enemyController;

    internal EnemyBase(GameObject go)
    {
        gameObject = go;
        // TryGetComponent<> 用来查找“EnemyController”组件，根据结果返回bool值
        // (out var enemyController) 是TryGetComponent<>返回true时，将组件赋值给enemyController
        if (!go.TryGetComponent<EnemyController>(out var enemyController))
        {
            // false enemyController add EnemyController组件
            enemyController = go.AddComponent<EnemyController>();
            Debug.Log("enemyController" + enemyController);
        }
        enemyController.Init(this);
    }

    public void SetPlayerTarget(PlayerController playerController)
    {
        Debug.Log("playerController :" + playerController);
        enemyController.SetTarget(playerController);
    }
}
