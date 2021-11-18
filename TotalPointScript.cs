using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPointScript : MonoBehaviour
{
    private int score = 0; //スコア
    [SerializeField] Text TotalText;    //トータルスコアの変数
    
    // Update is called once per frame
    void Update()
    {
        //トータルのスコアを代入
        score = UiScript.getScore();
        this.TotalText.text = "スコア：" + score.ToString("f0");

    }

    
}
