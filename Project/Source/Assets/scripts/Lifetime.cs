using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт удаления частиц выстрела через промежуток времени.
public class Lifetime : MonoBehaviour 
{

    float timer = 0.1f;

    void Update()
    {
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
        timer -= Time.deltaTime;
    }
}
