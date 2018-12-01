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

    [SerializeField]
    public List<Achivement> AvailebleAchivements;
    public GameObject AchivementPrefab;

	// Use this for initialization
	void Start () {

        AvailebleAchivements = new List<Achivement>();
        for (int i = 0; i < AchivementData.name.Count; i++)
        {
            Sprite newSprite = Resources.Load<Sprite>("Achivements/sprite" + i);
            Achivement loadAchivement = new Achivement(newSprite,AchivementData.name[i],AchivementData.Description[i]);
            AvailebleAchivements.Add(loadAchivement);
        }



        DemonGeneration = GetComponent<DemonGenerator>();
        GenerateNewGame();
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

    public void Die()
    {
        Debug.Log("Die " + Playthrough.Count);
        if(Playthrough.Count == 1)
        {
            Debug.Log("Die2");

            UnlockAchivement(AvailebleAchivements[0]);
        }
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
        NewEvent.GetComponent<Event>().SetDemon(Demon, Playthrough.Count);
        CurrentEvent = NewEvent;
        Playthrough.Add(NewEvent);
    }

    public void UnlockAchivement(Achivement achivement)
    {
        foreach (SavedAchivements ach in SaveLoad.CurrentSave.ClearedAchivements)
        {
            if (ach.Name == achivement.Name)
            {
                return;
            }
        }
        // check if exists
        GameObject NewAchivement = (GameObject)Instantiate(AchivementPrefab);
        NewAchivement.transform.SetParent(EventSpawn.transform, false);
        NewAchivement.GetComponent<AchivementSpanwed>().SetAchivement(achivement);
        SavedAchivements newSaveAchivement = new SavedAchivements(achivement.Name, achivement.Description);
        SaveLoad.CurrentSave.ClearedAchivements.Add(newSaveAchivement);
        SaveLoad.Save();
    }



}
