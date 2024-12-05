using UnityEngine;
using UnityEngine.SceneManagement;

public class LoreDump : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
