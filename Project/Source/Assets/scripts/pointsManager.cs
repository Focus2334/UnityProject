using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsManager : MonoBehaviour //������ ������ �� ����� ���������� � ���-�� ����������� ������
{
    public TextMeshProUGUI uGUI;

    void Update()
    {
        uGUI.text = "����������:" + Shooting.points;
    }
}
