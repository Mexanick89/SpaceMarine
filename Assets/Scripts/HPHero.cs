using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HPHero : MonoBehaviour
{
    Image HPbar;
    public float MaxHP = 100f;
    public float HP;

    void Start()
    {
        HPbar = GetComponent<Image>();
        HP = MaxHP;
    }

    void Update()
    {
        HPbar.fillAmount = HP/MaxHP;
    }
}
