using UnityEngine;
using System;


// Скрипт стрельбы; отвечает за уничтожение врагов, эффекты выстрела, регистрацию попаданий.
public class Shooting : MonoBehaviour 
{
    [SerializeField] Camera _camera;
    [SerializeField] string _enemy;
    [SerializeField] GameObject _particle;
    [SerializeField] GameObject _gun;
    public static int Points; // Кол-во уничтоженных врагов.

    private void Start()
    {
        Points = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !PauseMenu.m_Paused)
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, _camera.transform.forward);
            Physics.Raycast(ray, out hit, 1000f, LayerMask.GetMask("Default"));
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == _enemy)
                {
                    if (hit.collider.gameObject.GetComponent<EventAi>().Timer < 0)
                    {
                        hit.collider.gameObject.GetComponent<EventAi>().destroy();
                        Points += 1;
                    }
                    
                }
            }
            Instantiate<GameObject>(_particle, _gun.transform.position + _gun.transform.forward, _gun.transform.rotation);
        }

    }
}
