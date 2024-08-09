using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float life = 3;
    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
