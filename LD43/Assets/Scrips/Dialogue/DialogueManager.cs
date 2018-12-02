using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    public TextMeshPro nameText;
    public TextMeshPro dialogueText;

    public Animator animator;

    private Queue<string> sentences;

	// Use this for initialization
	void Start () {

        sentences = new Queue<string>();
	}

    public void StartDialogue(List<List<string>> listOfDialogue)
    {
        animator.SetTrigger("FadeIn");
        nameText.text = gameObject.name;
        int index = Random.Range(0, listOfDialogue.Count);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {


        Debug.Log("objet: " + gameObject.tag + " collision with: " + collision.gameObject);

        if ((collision.gameObject.tag == "Goblin") && (gameObject.tag == "Player"))
        {
            List<List<string>> listOfPlayerToGoblin = FindObjectOfType<DialogueList>().listOfPlayerToGoblin;
            StartDialogue(listOfPlayerToGoblin);
        }
        else if ((collision.gameObject.tag == "Player") && (gameObject.tag == "Goblin"))
        {
            List<List<string>> listOfGoblinToPlayer = FindObjectOfType<DialogueList>().listOfGoblinToPlayer;
            StartDialogue(listOfGoblinToPlayer);
        }
        else if ((collision.gameObject.tag == "Goblin") && (gameObject.tag == "Goblin"))
        {
            List<List<string>> listOfGoblinToGoblin = FindObjectOfType<DialogueList>().listOfGoblinToGoblin;
            StartDialogue(listOfGoblinToGoblin);
        }
        else if ((collision.gameObject.tag == "Player") && (gameObject.tag == "Checkpoint"))
        {
            List<List<string>> listOfCheckpoint = FindObjectOfType<DialogueList>().listOfCheckpoint;
            StartDialogue(listOfCheckpoint);
        }
        else if ((collision.gameObject.tag == "Player") && (gameObject.tag == "BigGoblin"))
        {
            List<List<string>> listOfBigGoblinToPlayer = FindObjectOfType<DialogueList>().listOfBigGoblinToPlayer;
            StartDialogue(listOfBigGoblinToPlayer);
        }
    }

}
