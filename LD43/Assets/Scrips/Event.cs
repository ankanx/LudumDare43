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
    public GameObject Trait1;
    public GameObject Trait2;

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
            Debug.Log(SecondChoise.GetComponent<Button>().interactable);
            StartedFire = true;
        }
        else if (SecondChoise.GetComponent<Button>().interactable == false && !StartedFire)
        {
            FirstChoise.GetComponent<Button>().interactable = false;
            FirstChoise.GetComponent<Animator>().SetBool("Active", false);
            GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Play();
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
        switch (demon.MainTrait1)
        {
            case Demon.Trait.Envy:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/envy");
                break;
            case Demon.Trait.Gluttony:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/gluttony");
                break;
            case Demon.Trait.Greed:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/greed");
                break;
            case Demon.Trait.Lust:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/lust");
                break;
            case Demon.Trait.Pride:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/pride");
                break;
            case Demon.Trait.Sloth:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/sloth");
                break;
            case Demon.Trait.Wrath:
                Trait1.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/wrath");
                break;

        }

        switch (demon.SecondTrait1)
        {
            case Demon.Trait.Envy:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/envy");
                break;
            case Demon.Trait.Gluttony:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/gluttony");
                break;
            case Demon.Trait.Greed:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/greed");
                break;
            case Demon.Trait.Lust:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/lust");
                break;
            case Demon.Trait.Pride:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/pride");
                break;
            case Demon.Trait.Sloth:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/sloth");
                break;
            case Demon.Trait.Wrath:
                Trait2.GetComponent<Image>().sprite = Resources.Load<Sprite>("SevenSins/wrath");
                break;
        }



    }

   
}
