using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// —крипт вывода на экран информации о кол-ве поверженных врагов.
public class pointsManager : MonoBehaviour 
{
    public TextMeshProUGUI uGUI;

    void Update()
    {
        uGUI.text = "”ничтожено:" + Shooting.Points;
    }
}
