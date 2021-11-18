using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    //スタートボタンの処理
    public void StartButton() {

        //MainSceneに遷移
        SceneManager.LoadScene("MainScene");

    }

    //エンドボタンの処理
    public void EndButton() {

        //アプリケーションの終了
        Application.Quit();

    }

    //タイトルボタンの処理
    public void TitleButton() {

        //スコアを0にする
        UiScript.setScore();
        //TitleSceneに遷移
        SceneManager.LoadScene("TitleScene");

    }

    //リトライボタンの処理
    public void RetryButton() {

        //スコア数を0にする
        UiScript.setScore();
        //MainSceneに遷移
        SceneManager.LoadScene("MainScene");

    }
}
