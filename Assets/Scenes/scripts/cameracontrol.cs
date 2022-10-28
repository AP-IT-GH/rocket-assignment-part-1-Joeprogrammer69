using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    // variabelen die thrust en tilt definiëren
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothingspeed = 10f;

    Transform playerTransform;
    // Start is called before the first frame update
    // object waarvan we onze camera gaan focussen
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

  
   private void FixedUpdate()
    {
        // we gaan een vector var initialiseren met de positie en de offset
        Vector3 targetPos = playerTransform.position + offset;
        //  we gaan de positie van de transform component pakken met de werkelijke object positie in functie met de tijd.
        transform.position = Vector3.Lerp(transform.position, targetPos,Time.deltaTime *  smoothingspeed);
        // zorg ervoor dat bij de trandform de camera altijd de positie zal volgen.
        transform.LookAt(playerTransform);
    }
}
