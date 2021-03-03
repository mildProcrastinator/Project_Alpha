using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public CarController player;
    public Text CrateCounter;

    private int noOfCrates;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        noOfCrates =  player.noOfCrates;
        CrateCounter.text = "CRATES "+ noOfCrates;

    }
}
