using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float carSpeed = 24.5f;
    private float turnSpeed = 35.4f;

    private float forwardInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        //Moving the vehicle forward, if the player presses to forward key.
        transform.Translate(Vector3.forward * Time.deltaTime *carSpeed *forwardInput);
        //Horizontal input of the vehicle, rotates the vehicle
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

    }
}
