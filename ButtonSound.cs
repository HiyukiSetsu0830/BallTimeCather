using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    private AudioSource buttonSound;    //AudioSource変数

    // Start is called before the first frame update
    void Start()
    {
        //AudioSourceコンポーネント代入
        buttonSound = GetComponent<AudioSource>();
    }

    public void isSound() {

        //SEを鳴らす
        buttonSound.PlayOneShot(buttonSound.clip);

    }
}
