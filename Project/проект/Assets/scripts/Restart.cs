using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour //Скрипт перезапуска игры через кнопку "Заново" в меню
{
    public void loadscene() //Загрузка сцены
    {
        SceneManager.LoadScene("SampleScene");
    }
}
