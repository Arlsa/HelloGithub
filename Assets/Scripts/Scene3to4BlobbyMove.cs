using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3to4BlobbyMove : MonoBehaviour
{
    private float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0.2f * speed);

        if (transform.position.y >= 41.5)
        {
            SceneManager.LoadScene("Stage 4");
        }
    }
}
