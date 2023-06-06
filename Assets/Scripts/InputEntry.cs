using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEntry : MonoBehaviour
{
    //dictionary values won't work, but floats can, so could create an array of the positions as float values 
    //from the Vector3, and then assign the numbrs thorugh this list that align with the tile at that position
    public int points;

    public InputEntry(int points) {
        this.points = points;
    }
}
