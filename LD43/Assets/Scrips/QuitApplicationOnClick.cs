using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitApplicationOnClick : MonoBehaviour {

    private Button thisButton;

    // Use this for initialization
    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(() => ExitApplication());
    }

    public void ExitApplication()
    {
        // save any game data here
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }


}
