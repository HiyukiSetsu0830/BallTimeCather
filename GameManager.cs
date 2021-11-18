using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text CountText;
    Coroutine coroutine;


    private float countDown = 5f;   //カウントダウン
    private int ballCount = 0;      //ボールの数
    private bool startText;         //STARTの表示判定
    private bool countDownText;     //カウントダウン表示判定
    private bool waveTwo;           //wave2判定
    private bool waveThree;         //wave3判定
    private bool waveFour;          //wave4判定（現在はエンド判定）
    private bool waveText2;         //wave2開始表示
    private bool waveText3;         //wave3開始表示
    private bool waveText4;         //wave4開始表示(現在はCLEAR表示)

    //Wave数の表示用の変数
    UiScript waveUi;

    // Start is called before the first frame update
    void Start()
    {
        //一時停止を解除する処理
        Time.timeScale = 1f;

        //Wave数表示
        waveUi = GameObject.Find("Canvas").GetComponent<UiScript>();
    }

    // Update is called once per frame
    void Update()
    {
         
        //カウントダウンテキストの表示
        if (countDown > 0.5) {
        
           countDown -= Time.deltaTime;
           CountText.text = countDown.ToString("f0");

         }

        //スタートテキストの表示
        if (countDown <= 0.5f && !startText) {

            startText = true;
            CountText.text = "S T A R T ！";

            Invoke("Delay", 1.0f);

        }

        //wave1のボール(15個)が消えたらwave2をTrue
        if (ballCount == 15) {

            waveTwo = true;
            
        }

        //wave2開始
        if (waveTwo) {
            
            waveTwo = false;

            //wave2カウントダウン
            if (!waveText2) {

                countDown = 6f;
                waveText2 = true;
                waveUi.AddWave();

            }

            //wave2テキスト表示
            if (countDown > 0.5f) {
                CountText.enabled = true;
                countDown -= Time.deltaTime;                
                CountText.text = "W a v e 2";
                

            }

            //スタートテキスト表示
            if (countDown <= 0.5f) {
                CountText.text = "S T A R T ！";
                Invoke("Delay", 1.0f);
                
            }

        }

        //wave2のボール(40個)が消えたらwave3をTrue
        if (ballCount == 40) {

            waveThree = true;
        }

        //wave3開始
        if (waveThree) {

            waveThree = false;
                        
            //wave3カウントダウン表示
            if (!waveText3) {
                
                countDown = 6f;
                waveText3 = true;
                waveUi.AddWave();

            }

            //wave3テキスト表示
            if (countDown > 0.5f) {
                CountText.enabled = true;
                countDown -= Time.deltaTime;
                CountText.text = "W a v e 3";
                


            }
            
            //スタートテキスト表示
            if (countDown <= 0.5f) {
                CountText.text = "S T A R T ！";
                Invoke("Delay", 1.0f);
            }

        }

        //wave3のボール(80個)消えたらwave4開始(現在はエンド処理)
        if (ballCount == 80) {

            waveFour = true;

        }

        //wave4開始(現在はエンド)
        if (waveFour) {

            waveFour = false;

            if (!waveText4) {

                countDown = 6f;
                waveText4 = true;
                
            }

            //エンドテキスト表示
            if (countDown > 0.5f) {

                CountText.enabled = true;
                countDown -= Time.deltaTime;
                CountText.text = "ALL WAVE END";
                
                
            }

            //EndSceneに遷移
            if (countDown <= 0.5f) {
                Invoke("Delay", 1.0f);
                SceneManager.LoadScene("EndScene");

            }

        }

    }

    //GameManager用 ボールの消えた数をカウントするメソッド
    public void GameAdmin() {

        ballCount += 1;

    }
}
