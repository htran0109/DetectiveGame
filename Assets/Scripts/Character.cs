using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Basic class for Characters in the game. Should contain at least
 * a description and a name.
 * Names should be unique, and will determine functionality.
 * A list of active characters should be contained within the game's Scene
 * at all times.
 **/
public class Character : MonoBehaviour
{
    public string charName;
    public string description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void setCharName(string newName)
    {
        charName = newName;
    }

    public void setCharDescription(string newDescription)
    {
        description = newDescription;
    }

    public string getCharName()
    {
        return charName;
    }

    public string getCharDescription()
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
        string text = System.IO.File.ReadAllText(@"Assets/Characters/" + filename);
        string[] splitText = System.Text.RegularExpressions.Regex.Split(text, @"\n\n");
        if (splitText.Length == 2)
        {
            setCharName(splitText[0]);
            setCharDescription(splitText[1]);
        }
        else
        {
            splitText = System.Text.RegularExpressions.Regex.Split(text, @"\r\n\r\n");
            if (splitText.Length != 2)
            {
                throw new System.Exception("Error parsing Assets/Characters/" + filename);
            }
            else
            {
                setCharName(splitText[0]);
                setCharDescription(splitText[1]);
            }
        }
    }
}
