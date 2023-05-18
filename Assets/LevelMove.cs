using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove : MonoBehaviour
{

    public int sceneIndex;

    private void OnTriggerEnter2D(Collider2D person) {
        if (person.tag == "Player") {
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        }
    }

}
