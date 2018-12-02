using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Event : MonoBehaviour {

    public string Name;
    public string DemonName;
    public Demon.Trait DemonMainTrait;
    public Demon.Trait DemonSecondTrait;
    public GameObject DemonNameText;
    public TextMeshProUGUI CurrentEventNumber;

    public GameObject FirstChoise;
    public GameObject SecondChoise;

    bool StartedFire = false;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        // Had to do this

        if (FirstChoise.GetComponent<Button>().interactable == false && !StartedFire)
        {
            SecondChoise.GetComponent<Button>().interactable = false;
            SecondChoise.GetComponent<Animator>().SetBool("Active", false);
            GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Play();
            Debug.Log("sds1");
            Debug.Log(SecondChoise.GetComponent<Button>().interactable);
            StartedFire = true;
        }
        else if (SecondChoise.GetComponent<Button>().interactable == false && !StartedFire)
        {
            FirstChoise.GetComponent<Button>().interactable = false;
            FirstChoise.GetComponent<Animator>().SetBool("Active", false);
            GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Play();
            Debug.Log("sds2");
            Debug.Log(FirstChoise.GetComponent<Button>().interactable);
            StartedFire = true;
        }

    }

    public void SetDemon(Demon demon, int currentEventNumber)
    {
        DemonNameText.GetComponent<TextMeshProUGUI>().text = demon.Name1;
        DemonName = demon.Name1;
        DemonMainTrait = demon.MainTrait1;
        DemonSecondTrait = demon.SecondTrait1;
        CurrentEventNumber.text = "Choise Number: " + currentEventNumber;
    }

   
}
