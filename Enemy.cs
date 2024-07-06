using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public float speed = 1;
    public float borderPosX;
    public Animator animator;
    public int damage = 5;
    public float hitInterval = 1;
    public float hitTimer = 0;
    public float addSpeed = 0.1f;
    public float maxSpeed = 2f;

    void Update()
    {
        if (gameObject.transform.position.x >= borderPosX)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
            if (hitTimer <= 0)
            {
                DealDamage();
                hitTimer = hitInterval;
            }
            else
            {
                hitTimer -= Time.deltaTime;
            }
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
        speed += addSpeed * LevelController.level;
        if (speed > 2)
        {
            speed = 2;
        }
    }

    public void DealDamage()
    {
        Corn.singleton.TakeDamage(damage);
    }

}
