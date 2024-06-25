using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int hp = 100;

    private void Awake()
    {
        singleton = this;
    }
    
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            print("кукуруза меньше 0 хп");
        }
    }
}
