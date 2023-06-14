using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapScript : MonoBehaviour
{
    Tilemap tilemap;

    TileBase tileCheck;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }
    // CHANGE TILES ACCORDING TO COLLISIONS
    /**
    void OnTriggerStay2D(Collider2D collision)
    {
        print("collided with" + collision.gameObject.tag);
        Vector3 hitPosition = Vector3.zero;
        {
            if (tilemap != null && Manager.Instance.go_Radar == collision.gameObject)
            {
                foreach (ContactPoint2D hit in collision.GetContacts)
                {
                    hitPosition.x = hit.point.x;
                    hitPosition.y = hit.point.y;
                    hitPosition.z = 0;
                    tileCheck = tilemap.GetTile(tilemap.WorldToCell(hitPosition));
                    if (tileCheck == tileBlack && tileCheck != null)
                    {
                        print(tilemap.WorldToCell(hitPosition));
                        //tilemap.SetTile(tilemap.WorldToCell(hitPosition), tileGreen); // PROBLEM: IT ONLY TURNS GREEN THE FIRST TILES IT COMES IN CONTACT WITH.
                    }
                }
            }
        }
    }*/
    
}

