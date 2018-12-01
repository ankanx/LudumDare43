using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SaveLoad.Load();
        Debug.Log("Debug : \n " + "Player Name: " + SaveLoad.CurrentSave.PlayerName + "\n Demon Name: " + SaveLoad.CurrentSave.DemonName + " \n Progress: " + SaveLoad.CurrentSave.progress + "\n ");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
