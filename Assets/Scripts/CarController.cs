using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float move, moveSpeed, rotation, rotationSpeed;
    public Rigidbody2D rb;
    private Vector2 movedir;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        rotationSpeed = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        //move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        movedir = new Vector2(moveX,moveY).normalized;
    }

    private void LateUpdate()
    {
            //transform.Translate(0f,move,0f);
            //transform.Rotate(0f,0f,rotation);

    }

    private void FixedUpdate()
    {
            rb.velocity = new Vector2(movedir.x * moveSpeed , movedir.y * moveSpeed);
    }
}
