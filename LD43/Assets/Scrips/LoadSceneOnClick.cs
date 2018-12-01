using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour {

    public int scene;
    private Button thisButton;
    private SceneLoader Sceneloader;

	// Use this for initialization
	void Start () {
        thisButton = GetComponent<Button>();
        Sceneloader = GameObject.FindGameObjectWithTag("SaveHandler").GetComponent<SceneLoader>();
        thisButton.onClick.AddListener(() => Sceneloader.LoadScene(scene,null));
    }
	
}
