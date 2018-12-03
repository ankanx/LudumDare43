using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextEvent : MonoBehaviour {

    public GameObject handler;
    public string type;

    private void Start()
    {
        handler = GameObject.FindGameObjectWithTag("GameController");
    }

    public void KillFire()
    {
        GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Stop();
    }

    public void TriggerDialog()
    {
        GameController.Choise choise = GameController.Choise.started;
        switch (type)
        {
            case "sheep":
                choise = GameController.Choise.Sacrificesheep;
                break;
            case "human":
                choise = GameController.Choise.SacrificeHuman;
                break;
        }



    }

    public void MoveToNextEventTrigger()
    {
        GameController.Choise choise = GameController.Choise.started;
        switch (type)
        {
            case "sheep":
                choise = GameController.Choise.Sacrificesheep;
                break;
            case "human":
                choise = GameController.Choise.SacrificeHuman;
                break;
        }

        handler.GetComponent<GameController>().GenerateEvent(choise);
    }
}
