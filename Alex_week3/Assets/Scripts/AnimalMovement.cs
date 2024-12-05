using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AnimalMovement : MonoBehaviour
{
    public float movementSpeed = 30;
    public float xRange, zRange;
    public int enemyHitPoints;

    Transform playerPosition;

    // Update is called once per frame
    void Update()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;

        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        transform.LookAt(playerPosition);

        //Breaking up the conditions with || serves to change the if() condition to "if any of these 4 things are true"
        if (transform.position.x < -xRange || transform.position.x > xRange || transform.position.z < -zRange || transform.position.z > zRange)
        {
            Destroy(gameObject);
        }

        if (enemyHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            enemyHitPoints--;
            ScoreandGameOver.score++;
            //in the ScoreandGameOver script, I set score as a public static variable (int), which combined with the line of code above, allows me to manipulate the score in the animal Script, without it BREAKING on me
            //due to the chickens being prefabs.
        }
    }
}
