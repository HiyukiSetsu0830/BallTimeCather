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
    private bool startText;
    private bool countDownText;
    private bool waveTwo;
    private bool waveThree;
    private bool waveFour;
    private bool waveText;
    private bool waveText3;
    private bool waveText4;
    private bool waveStart;

    //Wave数の表示用の変数
    UiScript waveUi;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        //Wave数表示
        waveUi = GameObject.Find("Canvas").GetComponent<UiScript>();
    }

    // Update is called once per frame
    void Update()
    {
         

        if (countDown > 0.5) {

           countDown -= Time.deltaTime;
           CountText.text = countDown.ToString("f0");

         }

        
        if (countDown <= 0.5f && !startText) {

            startText = true;
            CountText.text = "S T A R T ！";

            Invoke("Delay", 1.0f);

        }

        if (ballCount == 15) {

            waveTwo = true;
            
        }

        if (waveTwo) {
            
            waveTwo = false;

            if (!waveText) {

                countDown = 6f;
                waveText = true;
                waveUi.AddWave();

            }

            if (countDown > 0.5f) {
                CountText.enabled = true;
                countDown -= Time.deltaTime;                
                CountText.text = "W a v e 2";
                

            }

            if (countDown <= 0.5f) {
                CountText.text = "S T A R T ！";
                Invoke("Delay", 1.0f);
                
            }

        }

        if (ballCount == 40) {

            waveThree = true;
        }

        if (waveThree) {

            waveThree = false;
                        

            if (!waveText3) {
                
                countDown = 6f;
                waveText3 = true;
                waveUi.AddWave();

            }

            if (countDown > 0.5f) {
                CountText.enabled = true;
                countDown -= Time.deltaTime;
                CountText.text = "W a v e 3";
                


            }

            if (countDown <= 0.5f) {
                CountText.text = "S T A R T ！";
                Invoke("Delay", 1.0f);
            }

        }

        if (ballCount == 80) {

            waveFour = true;

        }

        if (waveFour) {

            waveFour = false;

            if (!waveText4) {

                countDown = 6f;
                waveText4 = true;
                
            }

            if (countDown > 0.5f) {

                CountText.enabled = true;
                countDown -= Time.deltaTime;
                CountText.text = "ALL WAVE END";
                
                
            }

            if (countDown <= 0.5f) {
                Invoke("Delay", 1.0f);
                SceneManager.LoadScene("EndScene");

            }

        }

    }



    void Delay() {

        CountText.enabled = false;
    }

    public void GameAdmin() {

        ballCount += 1;
        Debug.Log(ballCount);

    }

    private IEnumerator DelayMethod(float waitTime, System.Action action) {

         yield return new WaitForSeconds(waitTime);
         action();
    }
}
