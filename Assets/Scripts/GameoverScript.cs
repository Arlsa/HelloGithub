using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour
{
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -9){
            transform.position = new Vector2 (-6.01f, -2.3f);
            mainCamera.transform.position = new Vector3(0, 0, -10);
        }
    }
}
