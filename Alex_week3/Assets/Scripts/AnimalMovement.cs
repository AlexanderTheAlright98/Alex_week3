using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalMovement : MonoBehaviour
{

    public float movementSpeed = 30;
    public float xRange, zRange;
    public int enemyhitPoints;

    bool isGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        //Breaking up the conditions with || serves to change the if() condition to "if any of these 4 things are true"
        if (transform.position.x < -xRange || transform.position.x > xRange || transform.position.z < -zRange || transform.position.z > zRange)
        {
            Destroy(gameObject);
        }

        if (enemyhitPoints <= 0)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score++;
            // The line above finds the Player tag, then finds the Player script's score function, allowing me to edit it in this script
        }

        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            enemyhitPoints--;
        }

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            isGameOver = true;
            Time.timeScale = 0;
            Debug.Log("YOU'RE CLUCKED MATE!");
        }
    }
}
