using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    Rigidbody rb;
    private GameManager gamemanager;
    private int score;
    private float force = -0.0004f;
    private bool isSpeed = false;
    public int BallCount = 0;





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0f, force, 0f, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Catch")) {

            Destroy(this.gameObject);
            GameObject.Find("Canvas").GetComponent<UiScript>().AddScore();
            GameObject.Find("GameManager").GetComponent<GameManager>().GameAdmin();

        }

        if (collision.gameObject.CompareTag("Destroy")) {

            Destroy(this.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameAdmin();

        }

       /* if (collision.gameObject.CompareTag("Ground")) {
            if (isSpeed == false) {
                isSpeed = true;
                
                rb.AddForce(0f, force, 0f, ForceMode.Force);
            }

            isSpeed = false;

        }*/

        
    }

    
}
