using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1f;
    private float nextFireTime = 0;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryUnleashDog();
        }
    }

    void TryUnleashDog()
    {
        if (Time.time > nextFireTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextFireTime = Time.time + cooldownTime;
        }
        else
        {
            Debug.Log("Dog on cooldown");
        }
        
    }
}
