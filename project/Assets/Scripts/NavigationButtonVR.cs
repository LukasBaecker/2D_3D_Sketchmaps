using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
* A script for the two navigation buttons, that hide and show the navigation route and resets it.
*
*
*
*/
public class NavigationButtonVR : MonoBehaviour
{
    public GameObject button;
    public GameObject anotherButton;
    public GameObject navigationStripes;
    public NavigationButtonVR anotherButtonCollider;
    public UnityEvent onPress;
    GameObject presser;
    AudioSource sound;
    public bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        if (isPressed == true)
        {
            button.transform.localPosition = new Vector3(-16.12f, 2.9979f, -33.23f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            //make this button pressed and its sphere look pressed
            isPressed = true;
            button.transform.localPosition = new Vector3(-16.12f, 2.9979f, -33.23f);
            //reset the other button
            anotherButtonCollider.isPressed = false;
            anotherButton.transform.localPosition = new Vector3(-16.12f, 3.079f, -33.23f);
            //reset the position of the finish button anyway
            //finishButton.transform.localPosition = new Vector3(-5.87f, 3.079f, -35.33f);
            onPress.Invoke();
            sound.Play();
        }
    }

    public void ActivateNavigation()
    {
        navigationStripes.SetActive(true);
    }

    public void DeactivateNavigation()
    {
        //deavtivates all children of the navigationStripe group
        //for the red button we have to set the whole group of stripes and finish button as navigationStripes to deactivate the children
        for (int i = 0; i < navigationStripes.transform.childCount; i++)
        {
            var child = navigationStripes.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
}
