using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileCollider : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.tag == "Squares")
    {
        Tilemap map = collision.GetComponentInParent<Tilemap>();
        Vector3Int removePos = map.WorldToCell(transform.position);
        print(removePos);
        //map.SetTile(removePos, null);
    }
}


}
