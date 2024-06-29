using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawner;
    
    public void Victory()
    {
        print("You Victory");
    }

    public void Defeat()
    {
        print("You Defeat");
    }

    void Update()
    {
        Check();
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
