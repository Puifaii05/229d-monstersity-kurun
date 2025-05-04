using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("final");  // ������ Scene ���ͧ�س�ç���
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();  // ����Ѻ�͡�� (����੾�е͹ Build)
    }
}
