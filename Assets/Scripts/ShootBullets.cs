using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject gun;
    

    // Update is called once per frame
    void Update()
    {
        SpawnBullet();
        
    }

    void SpawnBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
        }
    }
}
