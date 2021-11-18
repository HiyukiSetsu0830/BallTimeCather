using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    //タイトルボタンを押された場合
    public void TitleButton() {

        //スコアを0にする
        UiScript.setScore();
        //TitleSceneに遷移
        SceneManager.LoadScene("TitleScene");

    }
}
