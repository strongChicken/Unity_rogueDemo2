using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    private Vector2 posit = new Vector2(-5.05f, 4.12f);

    public override void Build(Vector2 position, Quaternion ratation)
    {
        GameObject parentobj = new GameObject("normalEnemies");
        GameObject.Instantiate(((Resources.Load("prefabs/Enemy/Enemy01") as GameObject)), position, ratation).transform.SetParent(parentobj.transform);
        // TODO 生成坐标
    }

}
