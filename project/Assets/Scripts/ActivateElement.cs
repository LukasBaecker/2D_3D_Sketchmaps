using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/**
* script, that activates a disabled element
* the script is triggered by a collision with a trigger and then
* a given element that is deactivated will be activated
*/

/// <summary>
/// Script, that activates a disabled element.
/// The script is triggered by a collision with a trigger and then
/// a given element that is deactivated will be activated
/// </summary>
/// <param name="element">The deactivated element that should be activated. For the thesis this is meant to be a part of the navigation route.</param>
public class ActivateElement : MonoBehaviour
{
    public GameObject element;

    // Start is called before the first frame update
    // nothing to do for now
    void Start() { }

    // when a Rigidbody enters the trigger, the next segment will be activated.
    private void OnTriggerEnter(Collider other)
    {
        element.SetActive(true);
    }
}

/*
this script is used to activate the navigation stripes one after another when following the route.
*/
