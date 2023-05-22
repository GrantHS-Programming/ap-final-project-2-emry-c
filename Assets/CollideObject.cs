using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideObject : MonoBehaviour
{
    private Collider2D obj_Collider;
    [SerializeField]
    private ContactFilter2D obj_Filter; 
    private List<Collider2D> obj_CollidedObjects = new List<Collider2D>(1);


    protected virtual void Start()
    {
        obj_Collider = GetComponent<Collider2D>();
    }

    protected virtual void Update() 
    {
        //obj_Collider.OverlapCollider(obj_Filter, obj_CollidedObjects);
        foreach (var o in obj_CollidedObjects)
        {
            OnCollided(o.gameObject);
        }
    }

    protected virtual void OnCollided(GameObject collidedObject) 
    {
        Debug.Log("collided with" + collidedObject.name);
    }
}
