using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   //  [SerializeField] float xValue = 0;
  // [SerializeField] float yValue = 0.02f;

  //  [SerializeField]float zValue = 0;
        [SerializeField] float moveSpeed = 10f;

   
    void Start()
    {
      PrintInstructions();
    }
    
    void Update()
    {
        MovePlayer();
    }



     void PrintInstructions(){
     Debug.Log("Welcome to my game");
     Debug.Log("Move your player with WASD and arrow keys");
     Debug.Log("Don't hit the walls");
    }

    void MovePlayer(){
     float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
         
         
         
         transform.Translate(xValue,0,zValue);
    }
}
