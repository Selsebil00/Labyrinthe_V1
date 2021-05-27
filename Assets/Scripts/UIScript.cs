using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{     
    public void QuitGame()
    {
        Application.Quit();
    }
     // on peut ajouter les differents niveaux ... 
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
