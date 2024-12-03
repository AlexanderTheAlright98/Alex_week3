using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

    public float movementSpeed = 30;
    public float xRange, zRange;
    public int enemyhitPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        if (transform.position.x < -xRange || transform.position.x > xRange || transform.position.z < -zRange || transform.position.z > zRange)
        {
            Destroy(gameObject);
        }

        if (enemyhitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullets")
        {
            enemyhitPoints--;
        }
    }
}
