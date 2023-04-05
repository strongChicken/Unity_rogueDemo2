using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : EnemyBase
{
    public override void Build()
    {
        Object.Instantiate(Resources.Load("Boss") as GameObject);
    }
}
