using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static System.Action SaveInitiated;

    public static void OnsaveInitatated()
    {
        SaveInitiated?.Invoke();
    }
    
   
}
/*
    private void Start()
    {
        GameEvents.SaveInitiated += Save;
    }
    
    void Save()
    {
        SaveLoad.Save<>('name of object', "'a name'");
    } 
    public void Save()//button for saving
    {
        GameEvents.OnsaveInitatated();
    }
    void Load()
    {
        if (SaveLoad.SaveExists("'that name'"))
        {
            AddItems(SaveLoad.Load<>("'that name'"));
        }
    }
    public void DeleteAllProgress()
    {
        SaveLoad.SeriouslyDeleteAllSaveFiles();
    }
 */
