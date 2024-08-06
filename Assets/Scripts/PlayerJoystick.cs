using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        dirX = joystick.Horizontal*speed;
        dirY = joystick.Vertical*speed;
    }
    // rb.velocity.y
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal*speed,0,joystick.Vertical*speed);
        Vector3 directionVector = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        if (directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        if (joystick.Horizontal !=0)
        {
            animator.SetBool("Hero_Walk", true);
        }
        else
        {
            animator.SetBool("Hero_Walk", false);
        }
    }
}
