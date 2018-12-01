using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DemonGenerator : MonoBehaviour {

    List<string> DemonNames = new List<string>(new string[] {
        "Aguares",
        "Aamon",
        "Abbadon",
        "Azazel",
        "Baal",
        "Belial",
        "Daeva",
        "Demigure",
        "Demogorgon",
        "Drekavac",
        "Foras",
        "Gremory",
        "Gamingin",
        "Malthus",
        "Ipes",
        "Leviathan",
        "Ifrit",
        "Asmodeus",
        "Mammon",
        "Belphegor",
        "Cerbere",
        "Orias",
        "Pazuzu",
        "Valac",
        "Vapula",
        "Vassago",
        "Xaphan",
        "Zagan",
        "Xezbeth",
        "Vine",
        "Shuten Doji",
        "Yamauba",
        "Uji no hashihime",
        "Kiyohime"});


    public Demon GenerateDemon()
    {
        Demon.Trait one = Demon.TraitList[Random.Range(0, Demon.TraitList.Count)];
        Demon.Trait two = Demon.TraitList[Random.Range(0, Demon.TraitList.Count)];
        while(one == two)
        {
            two = Demon.TraitList[Random.Range(0, Demon.TraitList.Count)];
        }

        Demon NewDemon = new Demon(DemonNames[Random.Range(0,DemonNames.Count)], one, two);

        return NewDemon;
    }
}
