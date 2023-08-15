using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{

    //components 
    CarController carController;

    //Awake is called when the script instance is being loaded 
    void Awake()
    {
         carController = GetComponent<CarController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        carController.setInputVector(inputVector);

    }
}
