using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // เปลี่ยนตามชื่อซีนเกมจริง
    }

    public void QuitGame()
    {
        Application.Quit(); // จะทำงานจริงเมื่อ build เกมแล้วเท่านั้น
    }
}
