using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class UniqeID : MonoBehaviour
{
    public string ID { get; private set; }
    void Awake()
    {
        ID = transform.position.sqrMagnitude + "-" + name + "-" + transform.GetSiblingIndex();
        Debug.Log("Id for " + name + " is " + ID);
    }
}