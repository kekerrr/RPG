using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int speed = 5;

    void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
