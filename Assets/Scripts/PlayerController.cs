using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get input from the Oculus Touch controller
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        // Apply input as movement
        Vector3 move = new Vector3(input.x, 0, input.y);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
