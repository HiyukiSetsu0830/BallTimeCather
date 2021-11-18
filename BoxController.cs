using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    
    
    private float speed = 12f;  //スピード

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //操作
        var inputHorizontal = Input.GetAxis("Horizontal");

        //自機の移動設定
        var PlayerMove = new Vector3(inputHorizontal * speed * Time.deltaTime, 0f, 0f * speed * Time.deltaTime);
        transform.Translate(PlayerMove);

    }

    

}
