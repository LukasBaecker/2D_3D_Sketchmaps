using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    GameObject presser;
    AudioSource sound;

    public bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            //make this button look pressed
            button.transform.localPosition = new Vector3(-5.87f, 2.9979f, -35.33f);
            onPress.Invoke();
            sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //not pressed anymore
        button.transform.localPosition = new Vector3(-5.87f, 3.079f, -35.33f);
    }
}
