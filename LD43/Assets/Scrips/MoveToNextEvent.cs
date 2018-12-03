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
            case "dragon":
                choise = GameController.Choise.SlapaDragon;
                break;
            case "flip":
                choise = GameController.Choise.SlapaDragon;
                break;
            case "eye":
                choise = GameController.Choise.SlapaDragon;
                break;
            case "giraffe":
                choise = GameController.Choise.SlapaDragon;
                break;
            case "baby":
                choise = GameController.Choise.SlapaDragon;
                break;
            case "hand":
                choise = GameController.Choise.SlapaDragon;
                break;
        }

        handler.GetComponent<GameController>().TriggerDialog(choise);

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
