using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour

{

   private Rigidbody rb; 

    public float fuerzaSalto = 5;

    private bool isGrounded = true;

        void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (Input.GetKey("space") && isGrounded == true)
       {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        isGrounded = false;
       } 
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
