using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public int speed = 1;
    public float borderPosX;

    void Update()
    {
        if (gameObject.transform.position.x >= borderPosX)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        borderPosX = Corn.singleton.transform.position.x;
    }
}
