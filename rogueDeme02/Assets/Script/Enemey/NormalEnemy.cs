using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    private Vector2 posit = new Vector2(-5.05f, 4.12f);

    internal NormalEnemy(GameObject go) : base(go)
    {
    }

    public static NormalEnemy Build(Vector2 position, Quaternion rotation, [CanBeNull] Transform parent = null)
    {
        var go = Object.Instantiate(((Resources.Load("prefabs/Enemy/Enemy01") as GameObject)), position, rotation);
        if (parent != null)
        {
            go.transform.SetParent(parent, true);
        }
        // TODO 生成坐标

        return new NormalEnemy(go);
    }

}
