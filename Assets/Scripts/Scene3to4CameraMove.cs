using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3to4CameraMove : MonoBehaviour
{
    private float hangon;
    private float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        hangon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hangon++;
        if (hangon >= 55)
        {
            transform.position += new Vector3(0, 0.2f * speed);
        }
    }
}
