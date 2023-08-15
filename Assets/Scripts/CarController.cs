using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [Header("Car Settings")]
    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;

    //local variables
    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;

    //Components 
    Rigidbody2D carRigidbody2D;


    //awake is called when the script is being loaded
    private void Awake()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();   
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        ApplyEngineForce();

        ApplySteering();
        
    }

    void ApplyEngineForce()
    {
        //create a force for the engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        //apply force and pushes car forward
        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);

    }

    void ApplySteering()
    {
        //Update the rotation angle based on input
        rotationAngle -= steeringInput * turnFactor;

        //Appply steering by rotating the car object 
        carRigidbody2D.MoveRotation(rotationAngle);

        
    }

    public void setInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }




}
