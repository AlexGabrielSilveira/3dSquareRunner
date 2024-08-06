using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
   public Transform Player;
   public Vector3 Offset;

   void Update()
   {
      transform.position = Player.transform.position + Offset;
   }
}
