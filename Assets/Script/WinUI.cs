using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene"); // กลับไปเล่นใหม่
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // กลับเมนูหลัก
    }
}
