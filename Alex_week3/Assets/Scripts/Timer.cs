using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startTime = 120;
    private float currentTime;
    private bool timerStarted;
    public TMP_Text timerTXT;
    public TMP_Text nextLevelTXT;
    public bool playing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playing = true;
        Time.timeScale = 1;
        currentTime = startTime;
        timerTXT.text = currentTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            timerStarted = true;
        }

        if (timerStarted)
        {
            currentTime -= Time.deltaTime;
            timerTXT.text = "TIME: " + currentTime.ToString("f2");
        }

        if (currentTime <= 0)
        {
            Time.timeScale = 0;
            nextLevelTXT.text = "YOU SURVIVED! PRESS X TO KEEP GOING!";

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (SceneManager.GetActiveScene().name == "Level 1")
                {
                    SceneManager.LoadScene("Level 2");
                }
            }
        }
    }
}
