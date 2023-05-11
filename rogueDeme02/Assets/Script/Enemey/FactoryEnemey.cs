using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEnemey
{
    private static FactoryEnemey instance = null;

    private FactoryEnemey() { }

    public static FactoryEnemey GetInstance()
    {
        if (instance == null)
        {
            instance = new FactoryEnemey();
        }
        return instance;
    }

    public EnemyBase CreatEnemy(string name, Vector2 position, Quaternion ratation, Transform parent = null)
    {
        EnemyBase enemy = null;
        switch (name)
        {
            case ("Enemy01"):
                Debug.Log("Enemy01");
                enemy = NormalEnemy.Build(position, ratation, parent);
                break;
            case ("Enemy02"):
                enemy = BossEnemy.Build(position, ratation, parent);
                break;
        }
        return enemy;
    }
}
