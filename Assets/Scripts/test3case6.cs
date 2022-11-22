using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test3case6 : MonoBehaviour
{
   public float movespeed = 5f;
   public Vector3 moveDirecton;

   // Update is called once per frame
   public void Update()
   {
      Keyboard currentKeyboard = Keyboard.current;
      if (currentKeyboard.bKey.isPressed)
      {
         moveDirecton = Vector3.right;
      }
      else if (Input.GetKey("a"))
      {
         moveDirecton = Vector3.left;
      }
      else
      {
         moveDirecton = Vector3.zero;
      }
   }
   
   public void FixedUpdate()
   {
      Vector3 movement = moveDirecton * Time.fixedDeltaTime * movespeed;
      transform.position += movement;
   }
}
