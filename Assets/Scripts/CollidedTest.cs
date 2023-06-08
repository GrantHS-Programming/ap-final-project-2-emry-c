using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CollidedTest : MonoBehaviour
{
    public int Num;
    public BoundsInt area;
    
    public bool canInteract = false;

    private Vector3Int tilePosition;

    private Tilemap map;


    

void Update() 
   { 
     if (canInteract && Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Key 1 pressed");
            //SetTileData();
        }


 }
private void OnTriggerEnter2D(Collider2D tileCollidedWith)
    {

            Debug.Log($"touched {tileCollidedWith.name}");
            print("collided: " + tileCollidedWith);
            canInteract = true;

            
            
            
        
    //Vector3Int removePos = map.WorldToCell(transform.position);

        
           // public T GetTile(Vector3Int position);
            //print(position);
        
        

    }

    private void OnTriggerStay2D(Collider2D tileCollidedWith) {
        if (canInteract != true) {
            return;
        }
        print("can interact");
        print("person: " + transform.position);
        print("tile  : " + tileCollidedWith.gameObject.transform.position);
        if (map == null){
            map = tileCollidedWith.GetComponentInParent<Tilemap>();

            if (map != null) {
                TileBase[] tileArray = map.GetTilesBlock(map.cellBounds);
                for (int index = 0; index < tileArray.Length; index++){
                    TileBase tile = tileArray[index];
                    if (tile && tile.GetType() == typeof(Tile))
                    {
                        print("tile" + index + ": " + tile);
                    //if(tile.Contains(transform.position)    
                    }
                }

                // foreach(Vector3Int position in map.cellBounds.allPositionsWithin)
                // {
                //     Vector3 cellPosition = map.GetCellCenterWorld(position);
                //     print(cellPosition + "works" + Quaternion.identity);
                // }
            }
        }

        //print(transform.position);
        //print(removePos);
        //print(map.GetTile(removePos));
        //print(map.GetInstanceID());
        //map.SetTile(removePos, null);
        

        //print(person.transform.position);
        //tilePosition = Vector3Int.CeilToInt(person.transform.position);
        //print(tilePosition);
    }

    private void OnTriggerExit2D(Collider2D tileCollidedWith) {
        canInteract = false;
        print("Exit");
    }

   /** private void SetTileData(){
        Tilemap tilemap = GetComponent<Tilemap>();
        print(tilePosition);
        TileBase tile = tilemap.GetTile(tilePosition);
        //.gameObject.GetInstanceID();
        print(tile.GetInstanceID());
    }*/
}
