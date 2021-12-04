using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]

public class CollisionDetectionScript : MonoBehaviour
{
    [SerializeField] private TriggerEvent OnTriggerStay = new TriggerEvent();

    private void OnTriggerStay2D(Collider2D collision)
    {
        OnTriggerStay.Invoke(collision);
    }

    [Serializable]
    public class TriggerEvent : UnityEvent<Collider2D>
    {

    }
}
