using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Contains("Crate"))
        {
            player.GetComponent<CarController>().noOfCrates -= 1;
            col.gameObject.tag = "Untagged";
            Debug.Log(player.GetComponent<CarController>().noOfCrates);

        }
    }
}
