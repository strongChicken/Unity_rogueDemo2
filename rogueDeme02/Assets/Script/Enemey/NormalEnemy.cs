using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    private Vector2 posit = new Vector2(-5.05f, 4.12f);

    internal NormalEnemy(GameObject go) : base(go)
    {
    }

    public static NormalEnemy Build(Vector2 position, Quaternion ratation)
    {
        GameObject parentobj = new GameObject("normalEnemies"); // 意义不明
        
        var go = Object.Instantiate(((Resources.Load("prefabs/Enemy/Enemy01") as GameObject)), position, ratation);
        go.transform.SetParent(parentobj.transform);
        // TODO 生成坐标

        return new NormalEnemy(go);
    }

}
