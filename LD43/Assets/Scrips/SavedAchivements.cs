using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavedAchivements  {
    public string Name;
    public string Description;

    public SavedAchivements(string _name, string _desc)
    {
        Name = _name;
        Description = _desc;
    }

}
