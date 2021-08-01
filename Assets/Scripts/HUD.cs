using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    //import player object to pull ammo stats from
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get ammo from script 'Gun' in player, display
        this.GetComponent<Text>().text = "AMMO: " + System.Convert.ToString(player.GetComponent<Gun>().ammo);
    }
}
