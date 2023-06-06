using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializedField] InputField nameinput;

    List<InputEntry> entries = new List<InputEntry>();

    public void AddNameToList()
    {
        //instead of assigning a random number from 0, 100, have it be the num that the player pressed
        // which is saved in the collided test class
        entries.Add(new InputEntry(Random.Range(0, 100)));
 
    }
}
