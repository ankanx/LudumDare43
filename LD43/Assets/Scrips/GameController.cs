using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    public Demon Demon;
    DemonGenerator DemonGeneration;

    public List<GameObject> EventList;
    public List<GameObject> CurrenPlaythruEventList;
    public List<GameObject> Playthrough;

    public GameObject CurrentEvent;
    public GameObject EventSpawn;
    public GameObject ScoreScreen;


	// Use this for initialization
	void Start () {
        DemonGeneration = GetComponent<DemonGenerator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateNewGame()
    {
        Playthrough = new List<GameObject>();
        CurrenPlaythruEventList = new List<GameObject>(EventList);
        Demon = DemonGeneration.GenerateDemon();

        StartCoroutine("ShowScoreScreen");

        GenerateEvent(); 

    }

    IEnumerator ShowScoreScreen()
    {
        GameObject NewEvent = (GameObject)Instantiate(ScoreScreen);
        yield return new WaitForSeconds(1);
        //loadinganim.SetTrigger("Finished");
        //loadingText.text = "";
        yield return new WaitForSeconds(1);
        Destroy(NewEvent);

    }

    public void GenerateEvent()
    {
        if(Playthrough.Count > SaveLoad.CurrentSave.progress)
        {
            SaveLoad.CurrentSave.DemonName = Demon.Name1;
            SaveLoad.CurrentSave.progress = Playthrough.Count;
        }


        Destroy(CurrentEvent);
        GameObject NewEvent = (GameObject)Instantiate(EventList[Random.Range(0, EventList.Count - 1)]);
        NewEvent.name = NewEvent.GetComponent<Event>().Name + Playthrough.Count ;
        NewEvent.transform.SetParent(EventSpawn.transform,false);
        NewEvent.GetComponent<Event>().SetDemon(Demon);
        CurrentEvent = NewEvent;
        Playthrough.Add(NewEvent);
    }

}
