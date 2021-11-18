using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{

    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    //Canvasをセット
    public GameObject canvasObject;


    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (pauseUIInstance == null) {


                //GameObjectを生成、生成したオブジェクトを変数に代入
                pauseUIInstance = (GameObject)Instantiate(pauseUIPrefab);

                //Canvasの子要素として登録する 
                pauseUIInstance.transform.SetParent(canvasObject.transform, false);
                Time.timeScale = 0f;

            } else {

                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }
}