using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт триггера взаимодействия игрока с дверью.
public class DoorOpenTrigger : MonoBehaviour 
{
    [SerializeField] bool _open;
    [SerializeField] GameObject doorSystem;
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && doorSystem.GetComponent<DoorOpen>().Switching is false)
        {
            doorSystem.GetComponent<DoorOpen>().Open = _open;
        }
    }
}
