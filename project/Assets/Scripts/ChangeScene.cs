using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public int levelIndex;

    // Start is called before the first frame update
    void Start() { }

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
    }
}
