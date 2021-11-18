using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPointScript : MonoBehaviour
{
    private int score = 0; //スコア
    [SerializeField] Text TotalText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score = UiScript.getScore();
        this.TotalText.text = "スコア：" + score.ToString("f0");

    }

    
}
