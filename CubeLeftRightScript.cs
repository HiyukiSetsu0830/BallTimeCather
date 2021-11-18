using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLeftRightScript : MonoBehaviour
{

    private Vector3 targetpos;  //Vector3変数

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトの位置を取得
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトの回転
        transform.Rotate(1f, 0f, 1f);
        //オブジェクトの座標を代入
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetpos.x, targetpos.y, targetpos.z);
    }
}
