using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(List<List<string>> listOfDialogue)
    {

        animator.SetTrigger("FadeIn");
        nameText.text = gameObject.name;
        int index = Random.Range(0, listOfDialogue.Count);
        Debug.Log(listOfDialogue.Count);
        Debug.Log(index);
        List<string> dialogue = listOfDialogue[index];

        sentences.Clear();
        foreach (string sentence in dialogue)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNewSentence();
        
    }

    public void DisplayNewSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        StartCoroutine(WaitFiveSeconds());
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator WaitFiveSeconds()
    {
        yield return new WaitForSeconds(2.0f);
        DisplayNewSentence();
    }


    void EndDialogue()
    {
        animator.SetTrigger("FadeOut");
    }



    public void Trigger()
    {
        StartDialogue(GetComponent<DialogueList>().PlayerSpeach);
    }



}
