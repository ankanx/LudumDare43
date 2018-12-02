using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextEvent : MonoBehaviour {

    public GameObject handler;

    private void Start()
    {
        handler = GameObject.FindGameObjectWithTag("GameController");
    }

    public void KillFire()
    {
        GameObject.FindGameObjectWithTag("Fire").GetComponent<ParticleSystem>().Stop();
    }

    public void MoveToNextEventTrigger()
    {
        handler.GetComponent<GameController>().GenerateEvent();
    }
}
