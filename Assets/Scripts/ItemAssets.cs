using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Start() => Instance = this;

    public Transform pfItemWorld;

    public Sprite chest;
    //public Sprite one;
    //public Sprite two;
    //public Sprite three;
   //public Sprite four;
    //public Sprite five;
    //public Sprite six;
   // public Sprite seven;
    //public Sprite eight;
   // public Sprite nine;
}
