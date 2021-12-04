using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-2.5f * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2.5f * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(0, 20.0f * speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-2.5f * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(2.5f * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 20.0f * speed * Time.deltaTime, 0);
        }
    }
}
