using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CollidedTest : MonoBehaviour
{
    public int Num;
    public bool canInteract = false;

    private Vector3Int tilePosition;
   
void Update() 
   { 
     if (canInteract && Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Key 1 pressed");
            SetTileData();
        }
 }
private void OnTriggerEnter2D(Collider2D person)
    {
       if (person.tag == "Player") 
        { 
            print("collided" + Num);
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
        print(person.transform.position);
        tilePosition = Vector3Int.CeilToInt(person.transform.position);
        print(tilePosition);
    }

    private void OnTriggerExit2D(Collider2D person) {
        canInteract = false;
        print("Exit");
    }

    private void SetTileData(){
        Tilemap tilemap = GetComponent<Tilemap>();
        TileBase tile = tilemap.GetTile(tilePosition);
        //.gameObject.GetInstanceID();
        print(tile.GetInstanceID());
    }
}
