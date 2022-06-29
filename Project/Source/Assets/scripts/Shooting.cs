using UnityEngine;
using System;

public class Shooting : MonoBehaviour //Скрипт стрельбы; отвечает за уничтожение врагов, эффекты выстрела, регистрацию попаданий
{
    [SerializeField] Camera _camera;
    [SerializeField] string Enemy;
    [SerializeField] GameObject particle;
    [SerializeField] GameObject Gun;
    public static int points; //Кол-во уничтоженных врагов

    private void Start()
    {
        points = 0;
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
                if (hit.collider.gameObject.tag == Enemy)
                {
                    if (hit.collider.gameObject.GetComponent<EventAi>().timer < 0)
                    {
                        hit.collider.gameObject.GetComponent<EventAi>().destroy();
                        points += 1;
                    }
                    
                }
            }
            Instantiate<GameObject>(particle, Gun.transform.position + Gun.transform.forward, Gun.transform.rotation);
        }

    }
}
