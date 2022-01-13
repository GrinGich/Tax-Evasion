using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // så man kan använda SceneManagment.
public class SceneChangeButton : MonoBehaviour
{// Made by Felix.G
    [SerializeField]
    int sceneIndex; // SerializeField så att man kan använda samma script på varje knapp och bara ändra lokalt numret på scenen som du vill ladda.
    public void Restart()
    { // funktion som laddar scenen som du skrev in i fältet i inspektorn.
        SceneManager.LoadScene(sceneIndex);
    }
    public void Quit()
    { // Funktion som gör att när man trycker på knappen så kommer Applicationen Stängas ner.
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}