using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform enemy;
    private Vector2 posit = new Vector2(-5.05f, 4.12f);
    [SerializeField]private string playerRes;
    private GameObject enemyPrefab;

    #region

    private PlayerController playerController;

    #endregion

    // Start is called before the first frame update

    private void Awake()
    {
        enemyPrefab = Resources.Load<GameObject>("prefabs/Enemy/Enemy01");
        //playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Start()
    {
        SpawnPlayer();
        SpawnEnemy(playerController);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPlayer()
    {
        var playerPrefabs = Resources.Load<PlayerController>(playerRes);
        if(playerPrefabs != null)
        {
            playerController = Instantiate(playerPrefabs);
        }
    }

    void SpawnEnemy(PlayerController playerController)
    {
        FactoryEnemey factoryEnemey = FactoryEnemey.GetInstance();
        for(int i = 0; i <= 5; i++)
        {
            var parentObj = new GameObject("enemies");
            var enemy = factoryEnemey.CreatEnemy("Enemy01", posit, transform.rotation, parentObj.transform);
            enemy.SetPlayerTarget(playerController);
        }
        
    }
}
