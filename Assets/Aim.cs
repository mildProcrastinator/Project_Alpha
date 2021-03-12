using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    float mouseX, mouseY;
    Transform Gun;
    // Start is called before the first frame update
    void Start()
    {
        Gun = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");
        Gun.rotation = Quaternion.Euler(mouseX, mouseY, 0);

    }
}
