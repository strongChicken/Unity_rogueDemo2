using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class FactoryEnemey
{
    public static EnemyBase CreateEnemy(string key, Vector2 position, Quaternion rotation, [CanBeNull] Transform parent = null)
    {
        EnemyBase enemy = null; // 构造完之后, 再具体修改攻击力防御力的属性
        switch (key)
        {
            case ("Enemy01"):
                enemy = NormalEnemy.Build(position, rotation, parent);
                break;
            case ("Enemy02"):
                enemy = NormalEnemy.Build(position, rotation, parent);
                break;
        }
        return enemy;
    }
}
