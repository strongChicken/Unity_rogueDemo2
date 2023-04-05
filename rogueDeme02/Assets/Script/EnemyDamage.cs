using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private GameObject obj;
    private BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        string enemyName = GetComponent<GameObject>().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Åö×²ÉËº¦
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "play")
        {
            Debug.Log("Åöµ½Íæ¼Ò");
        }
    }
}
