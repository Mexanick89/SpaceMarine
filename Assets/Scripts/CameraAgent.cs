using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAgent : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        Initialization();
    }
    void Update()
    {
        TargetPosition();
    }

    private void Initialization()
    {
        offset = transform.position - target.position;
    }

    private void TargetPosition()
    {
        transform.position = target.position + offset;
    }
}
