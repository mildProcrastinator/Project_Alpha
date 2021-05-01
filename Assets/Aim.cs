using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    float mouseX, mouseY;
    public Camera cam;
    Vector2 mousePosition;
    Transform Gun;
    Vector2 bum;

    public float xRotation;
    public float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Gun = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        bum = new Vector2(Gun.position.x, Gun.position.y);
        Vector2 aimDir = mousePosition - bum;

        float angle = Mathf.Atan2(aimDir.y, aimDir.x) * Mathf.Rad2Deg;

        Gun.rotation = Quaternion.Euler(0,0,angle);
        Debug.Log(angle);
    }
}
