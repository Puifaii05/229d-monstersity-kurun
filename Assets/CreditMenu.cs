using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditMenu : MonoBehaviour
{
    // ���¡��Ѻ价��������ѡ
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  
    }

    // �Դ�����
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");  
    }
}
