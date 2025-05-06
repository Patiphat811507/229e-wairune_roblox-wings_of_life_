using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ชนะแล้ว! Player ชนเป้าหมาย");
            SceneManager.LoadScene("WinScene"); // ไปยังฉากจบเกม
        }
    }
}
