using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad : MonoBehaviour
{
    public static void Save<T>(T objectToSave, string key)
    {
        string path = Application.persistentDataPath + "/saveData/";
        Directory.CreateDirectory(path);
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fileStream = new FileStream(path + key + ".ost", FileMode.Create))
        {
            formatter.Serialize(fileStream, objectToSave);
        }
    }
    public static T Load<T>(string key)
    {
        string path = Application.persistentDataPath + "/saveData/";
        BinaryFormatter formatter = new BinaryFormatter();
        T returnValue = default(T);
        using (FileStream fileStream = new FileStream(path + key + ".ost", FileMode.Open))
        {
            returnValue = (T)formatter.Deserialize(fileStream);
        }

        return returnValue;
    }

    public static bool SaveExists(string key)
    {
        string path = Application.persistentDataPath + "/saveData/" + key + ".ost";
        return File.Exists(path);
    }
    public static void SeriouslyDeleteAllSaveFiles()
    {
        string path = Application.persistentDataPath + "/saveData/";
        DirectoryInfo directory = new DirectoryInfo(path);//if there are multiple characters only delete the character directory
        directory.Delete(true);
        Directory.CreateDirectory(path);
    }
}
