using UnityEngine.SceneManagement;
using UnityEngine;

// Скрипт перезапуска игры через кнопку "Заново" в меню.
public class Restart : MonoBehaviour 
{
    // Загрузка сцены.
    public void loadscene() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
