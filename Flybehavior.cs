using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code komt van https://www.youtube.com/watch?v=o9l699x_qZM

public class Flybehavior : MonoBehaviour

{
    // variabelen die thrust en tilt definiëren
    [SerializeField] float thrusterForce = 10f;
    [SerializeField] float tiltinForce = 10f;

    

    bool thrust = false;

    Rigidbody body;

    private void Awake()
    {
        // zorg ervoor dat het object fysieke components krijgt
        body = GetComponent<Rigidbody>();   
    }

   

    // Update is called once per frame
    private void Update()
    {
        
        float tilt = Input.GetAxis("Horizontal");
        // keyinputs
        thrust = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Space);
        // Nakijken of de rocket aan het bewegen is en daarna aan de hand van tilt de rocket laten roteren 
        if (!Mathf.Approximately(tilt,0f))
        {
            body.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f,0f, (tilt * tiltinForce * Time.deltaTime))));
        }
        
        body.freezeRotation = false;

    }

    private void FixedUpdate()
    {
        // rocket omhoog laten gaan
        if (thrust)
        {
            body.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
        }
    }
}
