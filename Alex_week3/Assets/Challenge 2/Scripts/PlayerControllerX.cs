using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCooldown = 0.75f;
    public float dogLastSpawned = 1.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogLastSpawned > dogCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogLastSpawned = 0;
        }

        dogLastSpawned += Time.deltaTime;
    }
}
