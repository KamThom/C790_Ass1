using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallPrefab : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision Detected with: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger Detected with: " + other.gameObject.name);
    }

}
