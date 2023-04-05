using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Transform enemy;
    private Vector2 posit = new Vector2(-5.05f, 4.12f);
    // Start is called before the first frame update
    void Start()
    {
        GameObject parentobj = new GameObject("enemies");
        for (int i = 0; i <= 5; i++)
        {
            // TODO 为什么prefabs的transform有特殊值
            GameObject.Instantiate((Resources.Load("prefabs/Enemy/Enemy01") as GameObject), new Vector2(-5.05f, 4.12f), transform.rotation).transform.SetParent(parentobj.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
