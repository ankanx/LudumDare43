using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad
{

    public static SaveData CurrentSave;

    //it's static so we can call it from anywhere
    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save.gd");
        bf.Serialize(file, SaveLoad.CurrentSave);
        file.Close();
    }

    public static void Load()
    {
        Debug.Log(Application.persistentDataPath + "/save.gd");
        if (File.Exists(Application.persistentDataPath + "/save.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.gd", FileMode.Open);
            SaveLoad.CurrentSave = (SaveData)bf.Deserialize(file);
            file.Close();
        }
        else
        {
            CurrentSave = new SaveData();
            CurrentSave.PlayerName = "";
            CurrentSave.DemonName = "";
            CurrentSave.progress = 0;
            CurrentSave.ClearedAchivements = new List<SavedAchivements>();
        }
    }
}