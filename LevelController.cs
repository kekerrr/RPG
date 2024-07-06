using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawner;
    public static bool finish = false;
    public static int level = 1;

    public void Start()
    {
        finish = false;
    }
    
    public void Victory()
    {
        print("You Victory");
        finish = true;
        level += 1;
    }

    public void Defeat()
    {
        print("You Defeat");
        finish = true;
        level = 1;
    }

    void Update()
    {
        if (finish == false)
        {
            Check();
        }
    }

    public void Check()
    {
        if (Corn.singleton.hp <= 0)
        {
            Defeat();
        }
        if (spawner.enemyCount <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if (enemies.Length <= 0)
            {
                Victory();
            }
        }
    }
}
