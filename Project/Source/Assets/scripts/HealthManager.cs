using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour //������ ��������� � ����������� �������� ������
{
    public static int health; //���-�� ����� ��������
    public static bool over; //������ ������ ������ (false - �����, true - ���������)
    public TextMeshProUGUI uGUI; //������ �� GUI � ������������ ����� ��������


    void Start()
    {
        health = 100;
        over = false;
    }
    void Update()
    {
        uGUI.text = "�� " + health;
        if (over)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void Damage(int count) //����� �������� � ����� �����, ����� �������� �� ����� ������� ������ ������
    {
        health -= count;
        if (health <= 0)
        {
            over = true;
        }
    }
}
