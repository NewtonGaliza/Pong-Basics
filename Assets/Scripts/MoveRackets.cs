using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRackets : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string axis;

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
