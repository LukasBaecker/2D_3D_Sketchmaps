using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A script for the two navigation buttons, that hide and show the navigation route and resets it.
/// </summary>
/// <param name="button">This is the visible button this collider belongs to.</param>
/// <param name="anotherButton">This is the second visible button with wich this collider and button collaborates.</param>
/// <param name="navigationStripes">This is the Element that should be displayed or hidden. For the thesis they are navigation parts.
/// the activating button takes the first element of the route and the deactivating button takes the whole container the parts of the navigation are children of.</param>
/// <param name="anotherButtonCollider">The collider of the second button.</param>
/// <param name="onPress">defines what happens on pressing the button.</param>
/// <param name="isPressed">The status if this button is pressed or not on of the two buttons should be pressed initially.</param>
/// <param name="sound">The audio source of this button. The sound will be played when the button is pushed.</param>
public class NavigationButtonVR : MonoBehaviour
{
    public GameObject button;
    public GameObject anotherButton;
    public GameObject navigationStripes;
    public NavigationButtonVR anotherButtonCollider;
    public UnityEvent onPress;
    public bool isPressed; //to set the position initially
    AudioSource sound;

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

    // this function should activate one single element of the navigation route
    // the element has to be inside a container as well as all other navigation element
    // because the DectivateNavigation function will take the whole container as a parameter and deactivates its children
    public void ActivateNavigation()
    {
        navigationStripes.SetActive(true);
    }

    // all navigation stripes and the finish button have to be in one container.
    // all elements in this container will be deactivated, regardless if they where activated or not.
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
