using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemey
{
    public EnemyBase CreatEnemy(string key, Vector2 position, Quaternion rotation)
    {
        EnemyBase enemy = null;
        switch (key)
        {
            case ("Enemy01"):
                enemy = NormalEnemy.Build(position, rotation);
                break;
            case ("Enemy02"):
                enemy = NormalEnemy.Build(position, rotation);
                break;
        }
        return enemy;
    }
}
