using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] chickens;
    public float spawnRangeX, spawnRangeZ;

    float startDelay = 1;
    float spawnInterval = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnTheChickens", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTheChickens()
    {
        int randomIndex = Random.Range(0, chickens.Length);

        Vector3 randomSpawn = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(chickens[randomIndex], randomSpawn, Quaternion.Euler(0, Random.Range(0, 360), 0));
        Vector3 randomSpawn2 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(chickens[randomIndex], randomSpawn2, Quaternion.Euler(0, Random.Range(0, 360), 0));
    }
}