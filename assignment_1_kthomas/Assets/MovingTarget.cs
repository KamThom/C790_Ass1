using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float speed = 2f;
    public float range = 5f;
    private Vector3 startPosition;
    public ParticleSystem hitEffect;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position = startPosition + new Vector3(Mathf.PingPong(Time.time * speed, range), 0, 0);
    }

    void OnCollisionEnter(Collision collision) 
{
    if (collision.gameObject.CompareTag("Ball"))
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        ContactPoint contact = collision.contacts[0];
        Vector3 contactPoint = contact.point;

        if (hitEffect != null)
        {
            Instantiate(hitEffect, contactPoint, Quaternion.identity);
        }
        else
        {
            Debug.LogError("hit error");
        }

        ScoreManager.AddScore(1); 
    }
}

}
