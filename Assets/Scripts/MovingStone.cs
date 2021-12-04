using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.x;
        max = transform.position.x + 12;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max - min) + min, transform.position.y, transform.position.z);
    }
}
