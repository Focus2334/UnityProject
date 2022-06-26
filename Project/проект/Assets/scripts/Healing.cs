using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour //Скрипт пополнения здоровья при подборе лечащих сфер
{
    [SerializeField] GameObject _player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            HealthManager.health += 20;
            Destroy(gameObject);
        }

    }
}
