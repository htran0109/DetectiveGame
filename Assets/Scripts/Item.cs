using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Basic class for Items to be used within the game.
 * All items should contain some value for the name and description field.
 * Comparisons for functionality will run off of the itemName field, as input
 * by other classes. indexed list of items should be included in the
 * game Scene at all times.
 **/
public class Item : MonoBehaviour
{

    public Item()
    {
        setItemName("testItem");
    }

    public Item(string itemName, string description)
    {
        setItemName(itemName);
        setItemDescription(description);
    }

    public string itemName;
    public string description;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setItemName(string newName)
    {
        itemName = newName;
    }

    public void setItemDescription(string newDescription)
    {
        description = newDescription;
    }

    public string getItemName()
    {
        return itemName;
    }

    public string getItemDescription()
    {
        return description;
    }

    /**
     * Loads an item from the corresponding Items/ file
     * Files should contain an item name in the first line of the file
     * followed by a single empty line with only a newline character
     * followed by the item description.
     */
    public void setItemFromFile(string filename)
    {
        string text = System.IO.File.ReadAllText(@"Assets/Items/" + filename);
        string[] splitText = System.Text.RegularExpressions.Regex.Split(text, @"\n\n");
        if(splitText.Length == 2)
        {
            setItemName(splitText[0]);
            setItemDescription(splitText[1]);
        }
        else
        {
            splitText = System.Text.RegularExpressions.Regex.Split(text, @"\r\n\r\n");
            if(splitText.Length != 2)
            {
                throw new System.Exception("Error parsing Assets/Items/" + filename);
            }
            else
            {
                setItemName(splitText[0]);
                setItemDescription(splitText[1]);
            }
        }

    }

    private void OnMouseDown()
    {
        //need to split description into multiple boxes if necessary.
        string[] sentences = splitDescription(description);
        FindObjectOfType<DialogueManager>().startDialogue(new Dialogue(sentences));
    }

    private string[] splitDescription(string description)
    {
        if (description.Length < Dialogue.MAX_TEXT_LENGTH)
        {
            return new string[] { description };
        }
        else
        { 
            //actually split the description into boxes
            int sentencesLength = (description.Length / Dialogue.MAX_TEXT_LENGTH) + 1;
            string[] sentences = new string[sentencesLength];
            for (int i = 0; i < sentencesLength; i++)
            {
                sentences[i] = description.Substring(i * Dialogue.MAX_TEXT_LENGTH, (i + 1) * Dialogue.MAX_TEXT_LENGTH);
            }
            return sentences;
        }
    }


}
