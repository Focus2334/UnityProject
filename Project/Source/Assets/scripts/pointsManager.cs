using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsManager : MonoBehaviour //—крипт вывода на экран информации о кол-ве поверженных врагов
{
    public TextMeshProUGUI uGUI;

    void Update()
    {
        uGUI.text = "”ничтожено:" + Shooting.points;
    }
}
