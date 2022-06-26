using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour //Скрипт выхода из игры через кнопку "выйти" в меню
{
    public void exit() //Метод выхода из игры
    {
        Application.Quit();
    }
}
