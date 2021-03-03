using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{
  public GameObject winText;

  void OnTriggerEnter2D(Collider2D col)
  {
      winText.gameObject.SetActive(true);
  }
}
