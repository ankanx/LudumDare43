using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon {

    string Name;
    Trait MainTrait;
    Trait SecondTrait;


    public enum Trait {
        Greed,
        Lust,
        Pride,
        Gluttony,
        Envy,
        Sloth,
        Wrath };

    public static List<Trait> TraitList = new List<Trait>( new Trait[] {Trait.Greed, Trait.Lust,Trait.Pride, Trait.Gluttony, Trait.Envy, Trait.Sloth, Trait.Wrath});

    public string Name1
    {
        get
        {
            return Name;
        }

        set
        {
            Name = value;
        }
    }

    public Trait MainTrait1
    {
        get
        {
            return MainTrait;
        }

        set
        {
            MainTrait = value;
        }
    }

    public Trait SecondTrait1
    {
        get
        {
            return SecondTrait;
        }

        set
        {
            SecondTrait = value;
        }
    }

    public Demon()
    {

    }

    public Demon(string _name, Trait _mainTrait, Trait _secondTrait)
    {
        Name1 = _name;
        MainTrait1 = _mainTrait;
        SecondTrait1 = _secondTrait;
    }

}
