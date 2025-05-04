using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("final");  // ใส่ชื่อ Scene เกมของคุณตรงนี้
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();  // สำหรับออกเกม (ใช้ได้เฉพาะตอน Build)
    }
}
