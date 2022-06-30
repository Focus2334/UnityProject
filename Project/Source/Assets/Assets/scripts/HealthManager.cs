using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// Скрипт изменения и отображения здоровья игрока.
public class HealthManager : MonoBehaviour 
{
    // Кол-во очков здоровья.
    public static int Health;

    // Статус смерти игрока (false - живой, true - уничтожен).
    public static bool Over;

    // ССылка на GUI с отображением очков здоровья.
    public TextMeshProUGUI uGUI; 


    void Start()
    {
        Health = 100;
        Over = false;
    }
    void Update()
    {
        uGUI.text = "ОЗ " + Health;
        if (Over)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    // Метод принятия и учёта урона, также отвечает за смену статуса смерти игрока.
    public void Damage(int count) 
    {
        Health -= count;
        if (Health <= 0)
        {
            Over = true;
        }
    }
}
