using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // s� man kan anv�nda SceneManagment.
public class SceneChangeButton : MonoBehaviour
{// Made by Felix.G
    [SerializeField]
    int sceneIndex; // SerializeField s� att man kan anv�nda samma script p� varje knapp och bara �ndra lokalt numret p� scenen som du vill ladda.
    public void Restart()
    { // funktion som laddar scenen som du skrev in i f�ltet i inspektorn.
        SceneManager.LoadScene(sceneIndex);
    }
    public void Quit()
    { // Funktion som g�r att n�r man trycker p� knappen s� kommer Applicationen St�ngas ner.
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}