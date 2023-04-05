using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform enemy;
    private Vector2 posit = new Vector2(-5.05f, 4.12f);

    private GameObject enemyPrefab;
    private void Awake()
    {
        enemyPrefab = Resources.Load<GameObject>("prefabs/Enemy/Enemy01");
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject parentObj = new GameObject("enemies");
        for (int i = 0; i <= 5; i++)
        {
            // TODO 为什么prefabs的transform有特殊值
            var enemy = FactoryEnemey.CreateEnemy("Enemy01", new Vector2(-5.05f, 4.12f), transform.rotation, parentObj.transform);
            // TODO 处理enemy
            // GameObject.Instantiate(enemyPrefab, new Vector2(-5.05f, 4.12f), transform.rotation).transform.SetParent(parentobj.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
