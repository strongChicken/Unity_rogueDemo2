using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemey
{
    EnemyBase enemy = null;
    NormalEnemy  normalEnemy = new NormalEnemy();
    BossEnemy bossEnemy = new BossEnemy();


    public EnemyBase CreatEnemy(string key)
    {
        switch (key)
        {
            case ("Enemy01"):
                enemy.Build();
                break;
            case ("Enemy02"):
                enemy.Build();
                break;
        }
        return enemy;
    }
}
