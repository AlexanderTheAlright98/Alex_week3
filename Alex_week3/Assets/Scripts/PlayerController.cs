using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 10;
    public float turnSpeed = 5;
    public float xRange = 23.7f;
    public float zRange = 16.6f;
    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //transform.Translate(movementSpeed * horizontal * Time.deltaTime * Vector3.right);
        //transform.Translate(movementSpeed * vertical * Time.deltaTime * Vector3.forward);

        Vector3 moveDir = new Vector3(horizontal, 0, vertical).normalized;
        transform.Translate(moveDir * movementSpeed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
