using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    [SerializeField]
    int levelToLoad;

    [SerializeField]
    bool autoindex = true;

    private void Start()
    {
        if(autoindex)
        {
            levelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
