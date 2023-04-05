using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : EnemyBase
{

    internal BossEnemy(GameObject go) : base(go)
    {
        
    }
    public static BossEnemy Build(Vector2 position, Quaternion rotation)
    {
        var go = Object.Instantiate(Resources.Load("Boss") as GameObject);
        return new BossEnemy(go);
    }
}
