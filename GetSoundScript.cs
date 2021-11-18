using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSoundScript : MonoBehaviour
{
    public AudioClip ballSound; //AudioClip変数

    //衝突判定
    private void OnCollisionEnter(Collision collision) {

        //衝突したオブジェクトのTagがBallだった場合
        if (collision.gameObject.CompareTag("Ball")) {

            //SE再生
            AudioSource.PlayClipAtPoint(ballSound, transform.position);

        }
    }
}
