using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 10;
    public int attack = 3;
    public float speed;
    private Rigidbody2D rigidbody2d;
    private Animator animator;


    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
        isOver();
    }

    private void Move(float speed)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);
        Vector2 position = rigidbody2d.position;
        position = position + speed * move * Time.deltaTime;
        rigidbody2d.MovePosition(position);

        animator.SetFloat("MoveX", horizontal);
        animator.SetFloat("MoveY", vertical);
    }

    private void isOver()
    {
        if (health <= 0)
        {
            Debug.Log("游戏结束");
        }
    }

    public void Injured(int amount)
    {
        health -= amount;
        Debug.Log("当前生命值" + health);
    }


}
