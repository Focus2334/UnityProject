using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour //Скрипт изменения и отображения здоровья игрока
{
    public static int health; //Кол-во очков здоровья
    public static bool over; //Статус смерти игрока (false - живой, true - уничтожен)
    public TextMeshProUGUI uGUI; //ССылка на GUI с отображением очков здоровья


    void Start()
    {
        health = 100;
        over = false;
    }
    void Update()
    {
        uGUI.text = "ОЗ " + health;
        if (over)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void Damage(int count) //Метод принятия и учёта урона, также отвечает за смену статуса смерти игрока
    {
        health -= count;
        if (health <= 0)
        {
            over = true;
        }
    }
}
