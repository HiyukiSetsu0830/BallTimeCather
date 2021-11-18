using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    Rigidbody rb;
    private float bumperPower;


    // Start is called before the first frame update
    void Start()
    {

        bumperPower = 1000f;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Ball")) {

            Rigidbody rb = collision.transform.GetComponent<Rigidbody>();
            rb.AddForce(-rb.velocity * bumperPower);

        }

    }
}
