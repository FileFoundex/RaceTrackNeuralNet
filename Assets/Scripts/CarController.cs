using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float move, moveSpeed, rotation, rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        rotationSpeed = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal")* -rotationSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
            transform.Translate(0f,move,0f);
            transform.Rotate(0f,0f,rotation);

    }
}
