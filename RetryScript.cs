using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{

    //リトライボタンを押された場合
    public void RetryButton() {

        //スコア数を0にする
        UiScript.setScore();
        //MainSceneに遷移
        SceneManager.LoadScene("MainScene");

    }
}
