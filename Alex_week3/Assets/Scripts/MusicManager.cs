using UnityEngine;

public class MusicManager : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        // This makes sure the song plays throughout the levels
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreandGameOver>().isGameOver)
        {
            Destroy(gameObject);
        }
        //This stops the song from overlapping on itself whenever you restart after a game over
    }
}
