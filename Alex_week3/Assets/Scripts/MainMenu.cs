using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void loreDump()
    {
        SceneManager.LoadScene("Expo Dump");
    }
}
