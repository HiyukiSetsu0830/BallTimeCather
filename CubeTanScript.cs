using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTanScript : MonoBehaviour
{

    private Vector3 targetpos;

    // Start is called before the first frame update
    void Start() {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(1f, 0f, 1f);
        transform.position = new Vector3(Mathf.Tan(Time.time) * 10.0f + targetpos.x, targetpos.y, targetpos.z);
    }
}