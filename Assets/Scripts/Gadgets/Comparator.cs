using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Interactible which allows the player to compare two items to find
 * discrepancies. Action function should spawn the prefabs necessary to
 * compare two items.
 */
public class Comparator : Interactible
{
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        action(new Item[] { new Item(), new Item() });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    override
    public void action(Item[] actionItems)
    {
        if(actionItems.Length != 2)
        {
            throw new System.Exception("Improper number of arguments for Comparator");
        }
        spawnItem(actionItems[0].getItemName(), 0);
        spawnItem(actionItems[1].getItemName(), 1);
    }

    /**
     * Spawn an item within the comparator based on its item name and position (0 for left, 1 for right)
     * Function will be somewhat complex as it will require data for all relevant items. However,
     * prefabs should be stored within the Scene object.
     */
    void spawnItem(string itemName, int position)
    {
        Instantiate(scene.testPrefab1, new Vector3(-3, 0, 0), Quaternion.identity);
        Instantiate(scene.testPrefab2, new Vector3(3, 0, 0), Quaternion.identity);
    }
}
