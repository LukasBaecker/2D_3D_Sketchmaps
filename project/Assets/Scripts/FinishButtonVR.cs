using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// class for a button that can be pushed
/// this button specifically is for the finish button of my thesis
/// to reuse the script change the absolute position of the button sphere, if the button is moved.
/// </summary>
/// <param name="button">This is the visible button this collider belongs to.</param>
/// <param name="onPress">defines what happens on pressing the button.</param>
/// <param name="isPressed">The status if this button is pressed or not on of the two buttons should be pressed initially.</param>
/// <param name="sound">The audio source of this button. The sound will be played when the button is pushed.</param>
public class FinishButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public bool isPressed;
    AudioSource sound;

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
            button.transform.localPosition = new Vector3(-5.87f, 2.9979f, -35.33f); //absolute position
            onPress.Invoke();
            sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //not pressed anymore
        button.transform.localPosition = new Vector3(-5.87f, 3.079f, -35.33f); //absolute position
    }
}
