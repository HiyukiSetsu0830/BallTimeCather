using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    Rigidbody rb;   //Rigidbody変数
    private GameManager gamemanager;    //GameManager変数
    private int score;                  //スコアの変数
    private float force = -0.0004f;     //加える力量

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyコンポーネント代入
        rb = GetComponent<Rigidbody>(); 
        //Rigidbodyに対して与える力
        rb.AddForce(0f, force, 0f, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    //衝突判定
    private void OnCollisionEnter(Collision collision) {

        //TagがCatchのオブジェクトの場合（自機）
        if (collision.gameObject.CompareTag("Catch")) {

            //オブジェクトを削除、スコア+1、ボールの消えた数に+1
            Destroy(this.gameObject);
            GameObject.Find("Canvas").GetComponent<UiScript>().AddScore();
            GameObject.Find("GameManager").GetComponent<GameManager>().GameAdmin();

        }

        //TagがDestroyのオブジェクトの場合
        if (collision.gameObject.CompareTag("Destroy")) {

            //オブジェクトを削除、ボールの消えた数に+1
            Destroy(this.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameAdmin();

        }
    }
}
