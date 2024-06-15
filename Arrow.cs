using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int speed = 5;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Enemy enemyScript = other.GetComponent<Enemy>();
            enemyScript.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
