using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 10;
    public float xRange = 23.7f;
    public float zRange = 16.6f;
    public GameObject projectilePrefab;
    public AudioClip meatFire;
    public AudioClip[] chickenNoise;

    private AudioSource sfxAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sfxAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        int randomIndex = Random.Range(0, chickenNoise.Length);

        Vector3 moveDir = new Vector3(horizontal, 0, vertical).normalized;
        transform.Translate(moveDir * movementSpeed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.LookRotation(moveDir);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation), 7);
            sfxAudio.PlayOneShot(meatFire);
        }

        if (GameObject.FindGameObjectWithTag("Animals").GetComponent<AnimalMovement>().enemyHitPoints == 0)
        {
            sfxAudio.PlayOneShot(chickenNoise[randomIndex]);
        }

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
    }
}
