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
    private EnemyController controller;

    internal EnemyBase(GameObject go)
    {
        gameObject = go;
        if (!go.TryGetComponent<EnemyController>(out var enemyController))
        {
            enemyController = go.AddComponent<EnemyController>();
        }

        controller = enemyController;
        enemyController.Init(this);
    }

    // 只用于Demo, 设定碰撞时, 目标是谁; 或者在碰撞时间的时候拿出对应的mono也可以; 
    public void SetPlayerTarget(PlayerController playerController)
    {
        controller.SetTarget(playerController);
    }
}
