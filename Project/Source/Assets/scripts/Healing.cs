using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт пополнения здоровья при подборе лечащих сфер.
public class Healing : MonoBehaviour 
{
    [SerializeField] GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            HealthManager.Health += 20;
            Destroy(gameObject);
        }

    }
}
