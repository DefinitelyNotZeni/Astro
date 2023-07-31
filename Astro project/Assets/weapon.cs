using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weap : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    bool down = false;

    public float FireDelay;
        

    void Start()
    {
        down = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            down = true;
            InvokeRepeating("Shoot", 0f, FireDelay);
            Debug.Log("Down");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Up");
            down = false;
            CancelInvoke("Shoot");
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
