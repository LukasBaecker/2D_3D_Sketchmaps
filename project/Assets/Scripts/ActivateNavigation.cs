using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/**
* script, that activates a disabled element
* the script is triggered by a collision with a trigger and then
* a given element that is deactivated will be activated
*/
public class ActivateNavigation : MonoBehaviour
{
    //the object that should be activated
    public GameObject nextSegment;

    // Start is called before the first frame update
    // nothing to do for now
    void Start() { }

    // when a Rigidbody body enters the trigger, the next segment will be activated.
    private void OnTriggerEnter(Collider other)
    {
        nextSegment.SetActive(true);
    }
}
