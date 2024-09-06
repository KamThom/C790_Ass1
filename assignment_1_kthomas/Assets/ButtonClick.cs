using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab;  
    private float forceAccumulated = 0f;  
    private float maxForce = 2000f;  
    private float forceIncreaseRate = 500f;  
    private float minForce = 300f;  
    private float ballLifetime = 6f;

    
    void Update()
    {
        
        if (Touchscreen.current.primaryTouch.press.isPressed) //touched?
        {
            forceAccumulated += forceIncreaseRate * Time.deltaTime;
            forceAccumulated = Mathf.Min(forceAccumulated, maxForce);
        }

        if (Touchscreen.current.primaryTouch.press.wasReleasedThisFrame) //released?
        {
            float finalForce = Mathf.Max(forceAccumulated, minForce);
            BallPrefab ball = Instantiate(ballPrefab);
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * finalForce);
            Destroy(ball.gameObject, ballLifetime);//delete ball
            forceAccumulated = 0f;
        }
    }
}
