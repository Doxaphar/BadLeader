using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.AddForce(Vector2.right * (speed * Input.GetAxis("Horizontal")), ForceMode2D.Impulse);
        _rb.AddForce(Vector2.up * (speed * Input.GetAxis("Vertical")), ForceMode2D.Impulse);
    }
}
