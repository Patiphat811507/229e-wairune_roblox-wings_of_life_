using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnKey : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name); // โหลดซีนปัจจุบันใหม่
        }
    }
}
