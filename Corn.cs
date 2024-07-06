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
        if (hp > 0)
        {
            hp -= damage;
        }
    }
}
