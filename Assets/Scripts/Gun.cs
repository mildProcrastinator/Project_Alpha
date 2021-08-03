using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Camera cam;
    public Rigidbody2D rb;

    public int ammo = 1;

    Vector2 mousepos;

    void Update()
    {
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookdir = mousepos - firePointPosition;
        
        //is player shooting?
        if (Input.GetButtonDown("Fire1"))
        {

            if (ammo >= 1)
            {
                //recoil
                rb.AddForce(new Vector2(lookdir.x * -6, lookdir.y * -19), ForceMode2D.Impulse);

                //call shoot method
                Shoot(new Vector3(lookdir.x, lookdir.y, 0));
                ammo -= 1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Pickup_Ammo"))
        {
            ammo++;
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }

    void Shoot (Vector2 aim)
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
