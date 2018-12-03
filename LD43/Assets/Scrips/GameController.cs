using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public DialogueManager DialogMan;

    public int Life = 1;
    public int Numofgames = 0;
    public int lasteventid = -1;

    public enum Choise
    {
        player,
        started,
        Sacrificesheep,
        Sacrificehumanbyburning,
        Offergold,
        offersownblood,
        HugaGiraffe,
        Asoulstone,
        BoonofGreed,
        BoonofWrath,
        BoonofEnvy,
        Flipatable,
        Feedabeggar,
        Sacrificeababy,
        SlapaDragon,
        Sacrificeaneye,
        Sacrificeahand,
        SacrificeHuman
    };

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
        lasteventid = -1;
        Numofgames++;
        Life = 1;
        Playthrough = new List<GameObject>();
        CurrenPlaythruEventList = new List<GameObject>(EventList);
        Demon = DemonGeneration.GenerateDemon();

        if(Numofgames == 1)
        {
            StartCoroutine("ShowScoreScreen", new List<string>(new string[] { "Generating New Worshipper... .. ." }));
        }else if(Numofgames == 2)
        {
            StartCoroutine("ShowScoreScreen",new List<string>(new string[]{ "Poor choise, the demon devoured you as a punishment...", "Lets Try Again..."}));
        }
        else
        {
            StartCoroutine("ShowScoreScreen", new List<string>(new string[] { "Poor choise, the demon devoured you as a punishment.. ." }));
        }




    }

    IEnumerator ShowScoreScreen(List<string> text)
    {

        GameObject NewEvent = (GameObject)Instantiate(ScoreScreen);
        foreach(string str in text)
        {
            NewEvent.GetComponentInChildren<TextMeshProUGUI>().text = str;
            yield return new WaitForSeconds(2.5f);
        }
        Destroy(NewEvent);
        GenerateEvent(Choise.started);
    }

    public void Die()
    {
        Debug.Log("Die " + Playthrough.Count);
        if(Playthrough.Count == 1)
        {

            UnlockAchivement(AvailebleAchivements[0]);
        }

        GenerateNewGame();
    }

    public void GenerateEvent(Choise choise)
    {
        Debug.Log(choise);

        CalculateIfSurvived(choise);




        GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Stop();
        if (Playthrough.Count > SaveLoad.CurrentSave.progress)
        {
            SaveLoad.CurrentSave.DemonName = Demon.Name1;
            SaveLoad.CurrentSave.progress = Playthrough.Count;
        }



        Destroy(CurrentEvent);
        int newEventId = Random.Range(0, EventList.Count - 1);
        while(newEventId == lasteventid)
        {
            newEventId = Random.Range(0, EventList.Count - 1);
        }
        GameObject NewEvent = (GameObject)Instantiate(EventList[newEventId]);
        NewEvent.name = NewEvent.GetComponent<Event>().Name + Playthrough.Count ;
        NewEvent.transform.SetParent(EventSpawn.transform,false);
        NewEvent.GetComponent<Event>().SetDemon(Demon, Playthrough.Count);
        CurrentEvent = NewEvent;
        Playthrough.Add(NewEvent);
        DialogMan = NewEvent.GetComponentInChildren<DialogueManager>();
        if (Playthrough.Count == 1)
        {
            DialogMan.TriggerStartSpeach(Choise.player);
        }else
        {
            DialogMan.Trigger(Choise.player);
        }
        
    }

    public void TriggerDialog(Choise choise)
    {
        DialogMan.Trigger(choise);
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

    public void CalculateIfSurvived(Choise choise)
    {
        if((choise == Choise.SacrificeHuman && Demon.SecondTrait1 == Demon.Trait.Lust) || (choise == Choise.SacrificeHuman && Demon.MainTrait1 == Demon.Trait.Lust))
        {
            Life -= 1;
        }


        if(Life <= 0)
        {
            Die();
        }
    }

}
