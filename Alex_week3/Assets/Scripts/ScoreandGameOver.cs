using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreandGameOver : MonoBehaviour
{
    public TMP_Text scoreStatText;
    public TMP_Text gameOverText;
    public static int score;
    public Renderer rend;
    public bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        rend = GetComponentInChildren<SkinnedMeshRenderer>();
        rend.enabled = true;

        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            score = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreStatText.text = "SCORE: " + score;

        if (isGameOver)
        {
            Time.timeScale = 0;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
            gameOverText.text = "YOU'RE CLUCKED! PRESS 'R' TO RESTART!";

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level 1");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animals")
        {
            isGameOver = true;
            rend.enabled = false;
        }
    }
}
