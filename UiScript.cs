using UnityEngine;
using UnityEngine.UI;


public class UiScript : MonoBehaviour
{

    [SerializeField] Text ScoreText; //スコア
    [SerializeField] Text WaveText;  //Wave数

    public static int score = 0;    //スコア初期化
    private float wave = 1;         //wave数の初期化

    
    void Start()
    {
        //Scoreオブジェクトのテキストコンポーネントを取得
        this.ScoreText = GameObject.Find("Score").GetComponent<Text>();
        //スコアを表示する
        this.ScoreText.text = "スコア:" + score.ToString("f0");
        //Waveオブジェクトのテキストコンポーネントを取得
        this.WaveText = GameObject.Find("Wave").GetComponent<Text>();
  
    }

    
    void Update()
    {
        //Wave数を表示する
        WaveText.text = "W a v e "+ wave.ToString("f0");

    }

    //スコアに+1するメソッド
    public void AddScore() {

        UiScript.score += 1;
        this.ScoreText.text = "スコア:" + score.ToString("f0");
    }

    //Wave数に+1するメソッド
    public void AddWave() {

        wave += 1;

    }

    //トータルスコアを表示するメソッド
    public void TotalScore() {

        this.ScoreText.text = "スコア:" + score.ToString("f0");

    }

    //トータルスコアを保存しておくメソッド（リザルト画面用）
    public static int getScore() {

        return UiScript.score;
    }

    //スコアを0に戻すメソッド
    public static int setScore() {

        return UiScript.score = 0;
        
    }


}
