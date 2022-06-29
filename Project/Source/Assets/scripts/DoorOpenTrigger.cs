using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour //Скрипт триггера взаимодействия игрока с дверью
{
    [SerializeField] bool Open;
    [SerializeField] GameObject doorSystem;
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && doorSystem.GetComponent<DoorOpen>().switching is false)
        {
            doorSystem.GetComponent<DoorOpen>().open = Open;
        }
    }
}
