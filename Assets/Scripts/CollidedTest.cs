using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidedTest : MonoBehaviour
{
    public int Num;
    public bool canInteract = false;
   
void Update() 
   { 
     if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            print("Key 1 pressed");
        }
 }
private void OnTriggerEnter2D(Collider2D person)
    {
       if (person.tag == "Player") 
        { 
            print("collided");
            canInteract = true;
           // public T GetTile(Vector3Int position);
            //print(position);
        }
        

    }

    private void OnTriggerStay2D(Collider2D person) {
        if (canInteract != true) {
            return;
        }
        print("can interact");
    }

    private void OnTriggerExit2D(Collider2D person) {
        canInteract = false;
        print("Exit");
    }
}
