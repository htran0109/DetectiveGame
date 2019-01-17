using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * abstract class for any interactible game mechanics.
 * Should contain any gadgets available to be used to provide new
 * functionality for the player. 
 * 
 * Interactible class is abstract in order to allow for differences in the
 * action() function.
 * 
 * All available interactibles should be contained within the Scene object
 * at any given time.
 */
public abstract class Interactible : MonoBehaviour
{
    public string gadgetName;
    private void Start()
    {

    }

    private void Update()
    {
        
    }

    abstract public void action(Item[] actionItems);
}
