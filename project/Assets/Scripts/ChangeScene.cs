using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//using UnityEngine.SceneManagement;

/// <summary>
/// A script to change the scene when colliding with a trigger
/// </summary>
/// <param name="levelIndex">Index of the scene that should be changed to. The index can be found at "Build Settings" -> "Scenes in Build" at the end of a row.</param>
public class ChangeScene : MonoBehaviour
{
    public int levelIndex;

    // Start is called before the first frame update
    void Start() { }

    //when entering the trigger, the Scene will be changed to the given levelIndex
    //the index can be found at "Build Settings" -> "Scenes in Build" at the end of a row
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
    }
}
