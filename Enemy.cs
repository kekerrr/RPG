using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    
    public void TakeDamage(int damage)
    {
        print("123");
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
