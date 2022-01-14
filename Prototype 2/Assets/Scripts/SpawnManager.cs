using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;

    [SerializeField]
    private float bounds = 9.5f;


    [Header("Spawn Timers")]
    [SerializeField]
    private float spawnStartDelay = 3;
    [SerializeField]
    private float spawnInterval = 2;


    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalPicker = Random.Range(0, animals.Length);
        float locationPicker = Random.Range(-bounds, bounds);

        Instantiate(animals[animalPicker], new Vector3(locationPicker, 0, 20), animals[animalPicker].transform.rotation);

    }
}
