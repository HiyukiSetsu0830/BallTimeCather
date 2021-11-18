using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    
    
    private float speed = 12f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        var inputHorizontal = Input.GetAxis("Horizontal");

        var PlayerMove = new Vector3(inputHorizontal * speed * Time.deltaTime, 0f, 0f * speed * Time.deltaTime);
        transform.Translate(PlayerMove);

    }

    

}
