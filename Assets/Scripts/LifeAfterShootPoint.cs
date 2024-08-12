using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAfterShootPoint : MonoBehaviour
{
    public float life = 3f;
    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
