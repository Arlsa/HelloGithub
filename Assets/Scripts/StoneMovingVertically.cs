using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovingVertically : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.y;
        max = transform.position.y + 12;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 4, max - min) + min, transform.position.z);
    }
}
