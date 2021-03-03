using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Camera cam;

    Vector2 mousepos;

    void Update()
    {
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookdir = mousepos - firePointPosition;

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(new Vector3(lookdir.x, lookdir.y, 0));
        }
    }


    void Shoot (Vector2 aim)
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
