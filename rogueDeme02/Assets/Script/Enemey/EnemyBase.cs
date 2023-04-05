using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyBase
{
    public int speed = 0;
    public int power = 0;
    public int attack = 0;
    public int health = 0;
    public int defend = 0;
    public int critical = 0;

    public virtual void Build(Vector2 position, Quaternion ratation)
    {

    }
}
