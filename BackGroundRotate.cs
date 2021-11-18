using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRotate : MonoBehaviour
{

    public Material sky;

    float rotationRepeatValue;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = sky;
    }

    // Update is called once per frame
    void Update()
    {
        
        rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + 0.01f, 360f);

        sky.SetFloat("_Rotation", rotationRepeatValue);
    }
}
