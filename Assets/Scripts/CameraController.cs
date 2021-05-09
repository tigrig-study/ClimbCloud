using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  private GameObject player;

  private void Start()
  {
    player = GameObject.Find("cat");
  }

  private void Update()
  {
    transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
  }
}
