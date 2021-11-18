using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSoundScript : MonoBehaviour
{
    public AudioClip ballSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Ball")) {


            //効果音再生
            AudioSource.PlayClipAtPoint(ballSound, transform.position);

        }
    }
}
