using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class WaveEnemy : MonoBehaviour
{
    public float fireRate = 1f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float nextFireTime;
    private float startY;

    Transform bulletHolder;

    void Start()
    {
        startY = transform.position.y;
        bulletHolder = GameObject.Find("bulletHolder").transform;
    }

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }

        // Horizontal movement
        
    }

    void Shoot()
    {
        // Perform raycast towards the player
        float shipRotation = firePoint.eulerAngles.z + 90f;
        float bulletRotation = shipRotation; 

        GameObject bulletObject = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.transform.SetParent(bulletHolder);
        Transform ship = null;
        
        if(GameObject.Find("Ship") != null)
        {   
            Debug.Log("Found ship");
            ship = GameObject.Find("Ship").transform;
        }
        if (bullet != null && ship != null)
        {
            Debug.Log("Launch towards");
            bullet.LaunchTowards(ship);
        }
        else if (bullet != null)
        {
            Debug.Log("Launch");
            bullet.Launch(bulletRotation);
        }
        if (ship == null) Debug.Log("No ship lol");
        if (bullet == null) Debug.Log("No bullet lol");

    }
}
