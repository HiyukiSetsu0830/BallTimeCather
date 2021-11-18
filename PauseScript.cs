using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{

    //　ポーズした時に表示するUIのプレハブ
    [SerializeField]  private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    //Canvasをセット
    public GameObject canvasObject;


    // Update is called once per frame
    void Update() {

        //ESCキーが押された場合
        if (Input.GetKeyDown(KeyCode.Escape)) {

            //ポーズUIのインスタンスがnullの場合
            if (pauseUIInstance == null) {
                
                //GameObjectを生成、生成したオブジェクトを変数に代入
                pauseUIInstance = (GameObject)Instantiate(pauseUIPrefab);

                //Canvasの子要素として登録する 
                pauseUIInstance.transform.SetParent(canvasObject.transform, false);
                //タイムスケールを0にして進行を止める。
                Time.timeScale = 0f;

            } else {
                //ポーズUIを削除して、進行させる
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}