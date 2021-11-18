using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRotate : MonoBehaviour
{

    public Material sky;        //マテリアル変数
    private float rotationRepeatValue;  //Math.Repeat代入する変数

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = sky;
    }

    // Update is called once per frame
    void Update()
    {
        
        //skuboxを回転させる
        rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + 0.01f, 360f);
        sky.SetFloat("_Rotation", rotationRepeatValue);
    }
}
