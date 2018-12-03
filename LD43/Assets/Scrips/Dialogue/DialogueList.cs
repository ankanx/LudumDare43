using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueList : MonoBehaviour {

    public List<List<string>> PlayerSpeach = new List<List<string>>{
    new List<string> {
        "A difficult choise..."
    },
    new List<string> {
        "Was this truly the right decision?",
        "I guess we will just have to wait and see..."
    },
    new List<string> {
        "I feel my power growing.",
        "My god what is that smell?"
    }
};

    public List<List<string>> SheepChoise = new List<List<string>>{
    new List<string> {
        "A sheep should suffice...",
        "I hope."
    }
    };

    public List<List<string>> GoldChoise = new List<List<string>>{
    new List<string> {
        "Why does such a powerful being crave such feeble objects?"
    }
    };

    public List<List<string>> GiraffeChoise = new List<List<string>>{
    new List<string> {
        "The giraffe was unexpectedly soft..",
        "ahem I mean the giraffe hs suffered my hug and so be appeased!"
    }
    };

    public List<List<string>> BloodChoise = new List<List<string>>{
    new List<string> {
        "A drop of blood to calm the nerves."
    }
    };

    public List<List<string>> DragonChoise = new List<List<string>>{
    new List<string> {
        "Let us consult the texts..",
        "'palmis caedebat a draconis'..",
        "ok then"
    }
    };

    public List<List<string>> HumanChoise = new List<List<string>>{
    new List<string> {
        "Another to satiate its hunger."
    }
    };

    public List<List<string>> DemonSpeech = new List<List<string>>
    {
    new List<string> {
        "You dare summon me?!",
        "I shall feast on your soul!"
    },
    new List<string> {
        "Foolish mortal!"
    },
    new List<string> {
        "Interesting.."
    }
    };

    // Each comma and " " is a new comment
    public List<List<string>> StarterSpeach = new List<List<string>>{
    new List<string> {
        "Rogamus vos et daemone, Da mihi postatem, et vitam diurnam!",
        "I invoke thee...",
        "The first thing I need to do after the summoning is appease the demon.",
        "Only then will it be willing to heed my plea."
    },
};


}
