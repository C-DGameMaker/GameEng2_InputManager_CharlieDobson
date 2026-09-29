using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector2 movement;
    private Rigidbody rb;

    [SerializeField] float movementSpeed = 5;
    [SerializeField] float jumpForce = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    public void OnJump()
    {
        if (Mathf.Abs(rb.linearVelocity.y) < 0.01f)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void HandleMovement()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y) * movementSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }
}
