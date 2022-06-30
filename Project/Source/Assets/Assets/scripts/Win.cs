using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Класс, отвечающий за вывод окна с информацией о победе.
public class Win : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] Image _button;
    [SerializeField] Text _text;
    [SerializeField] TextMeshProUGUI uGUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            _button.enabled = true;
            uGUI.enabled = true;
            _text.enabled = true;
            string text = uGUI.text + Shooting.Points;
            uGUI.text = text;
            Cursor.visible = true;
            Destroy(gameObject);
        }
    }
}
