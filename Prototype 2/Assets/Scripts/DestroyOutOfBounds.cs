using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField]
    private float topBound = 40f;
    [SerializeField]
    private float bottomBound = -10f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
