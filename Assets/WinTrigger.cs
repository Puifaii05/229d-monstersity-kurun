using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  // เพิ่มการใช้ SceneManagement

public class WinTrigger : MonoBehaviour
{
    public PlayerCollector player;  // อ้างถึงสคริปต์ที่เก็บคะแนน
    public GameObject winText;      // อ้างถึงข้อความ YOU WIN

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && player.score >= 9)
        {
            winText.SetActive(true);
            StartCoroutine(GoToCreditsAfterDelay());  // เรียก Coroutine ไปหน้าเครดิต
        }
    }

    private System.Collections.IEnumerator GoToCreditsAfterDelay()
    {
        yield return new WaitForSeconds(5f);  // หน่วงเวลา 5 วินาที
        SceneManager.LoadScene("CreditsScene");  // แก้ชื่อ Scene ให้ตรงกับ Scene เครดิตของคุณ
    }
}
