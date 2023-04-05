using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemey
{
    EnemyBase enemy = null;
    NormalEnemy  normalEnemy = new NormalEnemy();
    BossEnemy bossEnemy = new BossEnemy();


    public EnemyBase CreatEnemy(string key, Vector2 position, Quaternion ratation)
    {
        switch (key)
        {
            case ("Enemy01"):
                enemy.Build(position, ratation);
                break;
            case ("Enemy02"):
                enemy.Build(position, ratation);
                break;
        }
        return enemy;
    }
}
