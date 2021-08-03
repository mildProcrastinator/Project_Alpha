using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject loseText;
    public int noOfCrates;
    public float speed = 1500;
    public float tiltSpeed = 15f;
    private float movement = 0f;
    private float tilt = 0f;

    public GameObject spawnPoint;
    public WheelJoint2D frontWheel; 
    public WheelJoint2D backWheel;
    public Rigidbody2D rb;

    void  Start () 
    {
        //Move car to spawn point
        transform.position = spawnPoint.transform.position;
        //Set car's rotation to spawnpoint's
        transform.rotation = spawnPoint.transform.rotation;
    }
    void Update ()
    {
        if(noOfCrates == 0){
            loseText.gameObject.SetActive(true);
        }
        
        movement = -Input.GetAxisRaw("Vertical") * speed;
        tilt = Input.GetAxisRaw("Horizontal");

        //respawn - for playtesting only. 
        if (Input.GetKey("r"))
        {
            JointMotor2D motor = new JointMotor2D { motorSpeed = 0, maxMotorTorque = 10000 };
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
            rb.velocity = Vector3.zero;
            frontWheel.motor = motor;
            backWheel.motor = motor;
        }
    }

    void FixedUpdate () 
    {
        if (movement == 0)
        {
            frontWheel.useMotor = false;
            backWheel.useMotor = false;
        }
        else
        {
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 500};
            frontWheel.motor = motor;
            backWheel.motor = motor;
        }

        rb.AddTorque(-tilt * tiltSpeed * Time.fixedDeltaTime );
        
    }


}
