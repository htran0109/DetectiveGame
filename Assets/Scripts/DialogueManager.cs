using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        dialogueText = GameObject.Find("Dialogue").GetComponent<Text>();
    }

    public void startDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation");

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string typeText)
    {
        dialogueText.text = "";
        foreach (char letter in typeText.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("Ending dialogue");
    }
}
