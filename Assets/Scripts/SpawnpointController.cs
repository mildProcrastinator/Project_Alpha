using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointController : MonoBehaviour
{
    //setSpawnPoint
    public void setSpawnPoint(Vector3 newPoint) { transform.position =  newPoint; }
}
