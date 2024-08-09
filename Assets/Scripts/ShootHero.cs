using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHero : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    [SerializeField] AudioSource gun_Hero;
    public Animator animator;

    void Start()
    {
        Initialization();
    }

    public void GunButton()
    {
        gun_Hero.Play();
        StartAnimation();
        NewBullet();
        Invoke("StopAnimation", 0.7f);
    }

    public void StopAnimation()
    {
        animator.SetBool("Hero_Gun", false);
    }

    public void StartAnimation()
    {
        animator.SetBool("Hero_Gun", true);
    }

    private void Initialization()
    {
        animator = GetComponent<Animator>();
    }

    private void NewBullet()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }

}
