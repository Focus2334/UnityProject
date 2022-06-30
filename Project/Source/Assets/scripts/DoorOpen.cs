using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт анимации открытия двери.
public class DoorOpen : MonoBehaviour 
{
    float _angle;

    // Статус открыта/закрыта ли дверь.
    public bool Open = false;
    
    // Статус перехода в открытое/закрытое положение.
    public bool Switching = false; 

    private void Update()
    {
        if (Open && _angle < 90)
        {
            _angle += 100 * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(_angle, Vector3.up);
            Switching = true;
        }
        if (Open is false && _angle > 0)
        {
            _angle -= 100 * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(_angle, Vector3.up);
            Switching = true;
        }
        if (_angle >= 90 || _angle <= 0)
        {
            Switching = false;
        }

    }


}
