using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private int bounds = 15;

    // Update is called once per frame
    void Update()
    {
        int animalPicker = Random.Range(0, animals.Length);
        int locationPicker = Random.Range(-bounds, bounds);

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animals[animalPicker], new Vector3(locationPicker, 0, 20), animals[animalPicker].transform.rotation);
        }
        
    }
}
