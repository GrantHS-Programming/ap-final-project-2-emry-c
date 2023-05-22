using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollideObject
{
    protected override void OnCollided(GameObject collidedObject)
    {
        base.OnCollided(collidedObject);

        Debug.Log("XXX");
    }

}
