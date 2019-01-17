using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Container for the components of any given scene.
 * 
 * Should contain primarily:
 *  - Items
 *  - Characters
 *  - Gameplay elements (Whatever gadgets/interactives available.
 *                       Separate from descriptions/inspection tools for items)
 * 
 * Scene class will likely be most important for save/load features, but will be 
 *   made integral to the game in order to more easily facilitate save/load
 *  
 * Should grab items and characters from this scene object whenever they are needed
 * to be loaded in other contexts (In grid format, etc). Will be facilitated by 
 * getItem/getAllItem functions
 **/
public class Scene : MonoBehaviour
{
    public GameObject testPrefab1;
    public GameObject testPrefab2;
    public ArrayList itemList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addItem(string itemName, string description)
    {
        itemList.Add(new Item(itemName, description));
    }
}
