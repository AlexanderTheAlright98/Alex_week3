using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject animal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 randomSpawn = new Vector3(Random.Range(-22, 22), 0, Random.Range(-24, 24));
            Instantiate(animal, randomSpawn, Quaternion.Euler(0, Random.Range(0, 360), 0));
        }

    }
}