using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SaveLoad.Load();
        string debugstring = "Debug : \n " + "Player Name: " + SaveLoad.CurrentSave.PlayerName + "\n Demon Name: " + SaveLoad.CurrentSave.DemonName + " \n Progress: " + SaveLoad.CurrentSave.progress + "\n "; 
        foreach(SavedAchivements ach in SaveLoad.CurrentSave.ClearedAchivements)
        {
            debugstring += "\n " + ach.Name;
        }
        Debug.Log(debugstring);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
