using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour //Скрипт анимации открытия двери
{
    float _angle;
    public bool open = false; //Статус открыта/закрыта ли дверь
    public bool switching = false; //Статус перехода в открытое/закрытое положение

    private void Update()
    {
        if (open & _angle < 90)
        {
            _angle += 100 * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(_angle, Vector3.up);
            switching = true;
        }
        if (open is false & _angle > 0)
        {
            _angle -= 100 * Time.deltaTime;
            transform.rotation = Quaternion.AngleAxis(_angle, Vector3.up);
            switching = true;
        }
        if (_angle >= 90 || _angle <= 0)
        {
            switching = false;
        }

    }


}
