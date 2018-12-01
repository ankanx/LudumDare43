using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Achivement {
    public Sprite sprite;
    public string Name;
    public string Description;

    public Achivement(Sprite _sprite, string _name, string _desc)
    {
        sprite = _sprite;
        Name = _name;
        Description = _desc;
    }
}
