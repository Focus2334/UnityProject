using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour //������ �������� ������ �������� ����� ���������� �������
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
