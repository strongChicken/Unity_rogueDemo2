using UnityEngine;

public class EnemyBase
{
    public int speed = 0;
    public int power = 0;
    public int attack = 0;
    public int health = 0;
    public int defend = 0;
    public int critical = 0;

    public GameObject gameObject { get; }

    internal EnemyBase(GameObject go)
    {
        gameObject = go;
    }
}
