using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycstHero : MonoBehaviour
{
    public float raycastDistance = 10f;
    public Color raycastColor = Color.red;

    [SerializeField] private ParticleSystem fireGun;

    [SerializeField] private AudioSource fireGunSound;

    public GameObject objectToSpawn;

    void Update()
    {
        RayLine();
    }

    public void RayCastButton()
    {
        fireGun.Play();
        fireGunSound.Play();

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);

            // GameObject spawnedObject = Instantiate(objectToSpawn, hit.point, Quaternion.identity);

            GameObject spawnedObject = Instantiate(objectToSpawn, hit.point, Quaternion.LookRotation(hit.normal));
        }

    }
    private void RayLine()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        Debug.DrawRay(origin, direction * raycastDistance, raycastColor);

        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, raycastDistance))
        {
           // Debug.Log("Hit: " + hit.transform.name);
        }
    }

}
