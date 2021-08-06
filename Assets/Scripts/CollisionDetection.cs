using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag.ToString());
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.GetComponent<Gun>().ammo += 5;
            Destroy(gameObject);
        }
    }
}
