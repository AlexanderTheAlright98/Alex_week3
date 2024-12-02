using UnityEngine;

public class FoodProjectile : MonoBehaviour
{

    public float projectileSpeed = 30;
    public float xRange = 23.7f;
    public float zRange = 16.6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zRange)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > zRange)
        {
            Destroy(gameObject);

        }
    }
}
