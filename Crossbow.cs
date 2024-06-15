using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public float shootInterval = 0.75f;
    public float shootTimer = 0;
    public GameObject arrowPrefab;

    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            if (shootTimer <= 0)
            {
                Instantiate(arrowPrefab, transform.position, transform.rotation);
                shootTimer = shootInterval;
            }

        }

        Vector2 mouseScreenPos = Input.mousePosition; // координаты мышки на экране
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos); // перводим координаты на экране на координаты сцены

        Vector2 wantedDirection = mouseScenePos - (Vector2)gameObject.transform.position; // находим ввектор от положения арбалета в сторону мышки
        Vector2 defaultDirection = Vector2.up; // вектор в право

        float angle = Vector2.SignedAngle(defaultDirection, wantedDirection); //находим угол между векторами стандартного вектора и вектора в сторону мышки
        Vector3 newEuler = new Vector3(0, 0, angle); //создаём угол поворота
        gameObject.transform.localEulerAngles = newEuler; //отдаём угол повотора нашему обьекту 
    }
}
