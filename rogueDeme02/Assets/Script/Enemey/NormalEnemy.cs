using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    internal NormalEnemy(GameObject go): base(go) { }

    // "Transform parent = null" 参数默认值null
    public static NormalEnemy Build(Vector2 position, Quaternion ratation, Transform parent = null)
    {
        //GameObject parentobj = new GameObject("normalEnemies");
        var go = GameObject.Instantiate(((Resources.Load("prefabs/Enemy/Enemy01") as GameObject)), position, ratation);
        //go.transform.SetParent(parentobj.transform);

        if(parent != null)
        {
            go.transform.SetParent(parent); // TODO 父物体是什么
        }

        // TODO 生成坐标

        return new NormalEnemy(go);
    }
}
