using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// ������ ��������� � ����������� �������� ������.
public class HealthManager : MonoBehaviour 
{
    // ���-�� ����� ��������.
    public static int Health;

    // ������ ������ ������ (false - �����, true - ���������).
    public static bool Over;

    // ������ �� GUI � ������������ ����� ��������.
    public TextMeshProUGUI uGUI; 


    void Start()
    {
        Health = 100;
        Over = false;
    }
    void Update()
    {
        uGUI.text = "�� " + Health;
        if (Over)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    // ����� �������� � ����� �����, ����� �������� �� ����� ������� ������ ������.
    public void Damage(int count) 
    {
        Health -= count;
        if (Health <= 0)
        {
            Over = true;
        }
    }
}
