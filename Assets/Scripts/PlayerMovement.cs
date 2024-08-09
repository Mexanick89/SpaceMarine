using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;
    public Animator animator;

    void Start()
    {
        Initialization();
    }

    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        ChangeAnimation();
        ChangeDirection();
        Direction();
    }

    private void ChangeAnimation()
    {
        if (joystick.Horizontal !=0)
        {
            animator.SetBool("Hero_Walk", true);
        }
        else
        {
            animator.SetBool("Hero_Walk", false);
        }
    }

    private void ChangeDirection()
    {
        Vector3 directionVector = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        if (directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.LookRotation(directionVector);
    }

    private void Direction()
    {
        rb.velocity = new Vector3(joystick.Horizontal*speed, 0, joystick.Vertical*speed);
    }

    private void Initialization()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Movement()
    {
        dirX = joystick.Horizontal*speed;
        dirY = joystick.Vertical*speed;
    }

}
