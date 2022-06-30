using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Класс закрытия окна с информацией о победе.
public class WinClose : MonoBehaviour
{
    [SerializeField] Image _button;
    [SerializeField] Text _text;
    [SerializeField] TextMeshProUGUI uGUI;

    private void Update()
    {
        if (_button.enabled == true && Input.GetKeyDown(KeyCode.Escape))
        {
            close();
        }
    }

    // Метод отключает элементы UI с информацией о победе.
    public void close()
    {
        _button.enabled = false;
        uGUI.enabled = false;
        _text.enabled = false;
        Cursor.visible = false;
    }
}
