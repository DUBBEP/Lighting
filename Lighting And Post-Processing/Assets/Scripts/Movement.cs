using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    public Rigidbody rb;

    private float vInput = 0f;
    private float hInput = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(vInput, 0f, -hInput);
        rb.MovePosition(this.transform.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

    }
}
