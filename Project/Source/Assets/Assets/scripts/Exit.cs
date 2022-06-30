using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт выхода из игры через кнопку "выйти" в меню.
public class Exit : MonoBehaviour 
{
    // Метод выхода из игры.
    public void exit() 
    {
        Application.Quit();
    }
}
