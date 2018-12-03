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

    public void StartDialogue(List<List<string>> listOfDialogue, string who)
    {

        animator.SetTrigger("FadeIn");
        if (who == "Player")
        {
            nameText.text = "Player";
        }
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
        yield return new WaitForSeconds(3.0f);
        DisplayNewSentence();
    }


    void EndDialogue()
    {
        animator.SetTrigger("FadeOut");
    }



    public void Trigger(GameController.Choise choise)
    {
        switch (choise)
        {
            case GameController.Choise.player:
                StartDialogue(GetComponent<DialogueList>().PlayerSpeach, "Player");
                break;
            case GameController.Choise.Sacrificesheep:
                StartDialogue(GetComponent<DialogueList>().SheepChoise, "Player");
                break;
            case GameController.Choise.SlapaDragon:
                StartDialogue(GetComponent<DialogueList>().DragonChoise, "Player");
                break;
            case GameController.Choise.HugaGiraffe:
                StartDialogue(GetComponent<DialogueList>().GiraffeChoise, "Player");
                break;
            case GameController.Choise.Sacrificeababy:
                StartDialogue(GetComponent<DialogueList>().PlayerSpeach, "Player");
                break;
            case GameController.Choise.Sacrificeahand:
                StartDialogue(GetComponent<DialogueList>().PlayerSpeach, "Player");
                break;
            case GameController.Choise.Sacrificeaneye:
                StartDialogue(GetComponent<DialogueList>().PlayerSpeach, "Player");
                break;
        }
    }

    public void TriggerStartSpeach(GameController.Choise choise)
    {
        Debug.Log("Starter Dialog");
        switch (choise)
        {
            case GameController.Choise.player:
                StartDialogue(GetComponent<DialogueList>().StarterSpeach, "Player");
                break;
        }
        
    }


}
