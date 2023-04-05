using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : EnemyBase
{
    public override void Build(Vector2 position, Quaternion ratation)
    {
        Object.Instantiate(Resources.Load("Boss") as GameObject);
    }
}
