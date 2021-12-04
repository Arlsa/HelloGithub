using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public GameObject mainCamera;
    public int health;
    public Text hpText;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = "HP : " + health.ToString();
        if (health <= 0)
        {
            transform.position = new Vector2(-6.01f, -2.3f);
            mainCamera.transform.position = new Vector3(0, 0, -10);
            health = 3;
        }
    }

    void Damage()
    {
        health--;
        Debug.Log(health);
    }
}
