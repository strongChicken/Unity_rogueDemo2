using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    internal NormalEnemy(GameObject go): base(go) { }

    // "Transform parent = null" ����Ĭ��ֵnull
    public static NormalEnemy Build(Vector2 position, Quaternion ratation, Transform parent = null)
    {
        //GameObject parentobj = new GameObject("normalEnemies");
        var go = GameObject.Instantiate(((Resources.Load("prefabs/Enemy/Enemy01") as GameObject)), position, ratation);
        //go.transform.SetParent(parentobj.transform);

        if(parent != null)
        {
            go.transform.SetParent(parent); // TODO ��������ʲô
        }

        // TODO ��������

        return new NormalEnemy(go);
    }
}
