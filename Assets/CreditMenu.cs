using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditMenu : MonoBehaviour
{
    // เรียกกลับไปที่เมนูหลัก
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  
    }

    // ปิดเกมเลย
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");  
    }
}
