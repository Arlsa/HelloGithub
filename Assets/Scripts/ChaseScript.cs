using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseScript : MonoBehaviour
{
    public GameObject target;
    Rigidbody2D agentRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        agentRigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnDetectObject(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            float distance = Vector2.Distance(transform.position, target.transform.position);
            Vector2 destination = target.transform.position - transform.position;
            if (distance > 0)
            {
                agentRigidbody.AddForce(destination * 1f, ForceMode2D.Force);
            }
        }
    }
}
