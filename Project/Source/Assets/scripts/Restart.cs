using UnityEngine.SceneManagement;
using UnityEngine;

// ������ ����������� ���� ����� ������ "������" � ����.
public class Restart : MonoBehaviour 
{
    // �������� �����.
    public void loadscene() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
