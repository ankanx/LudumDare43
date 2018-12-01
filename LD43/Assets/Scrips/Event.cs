using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Event : MonoBehaviour {

    public string Name;
    public string DemonName;
    public Demon.Trait DemonMainTrait;
    public Demon.Trait DemonSecondTrait;
    public GameObject DemonNameText;
    public TextMeshProUGUI CurrentEventNumber;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
