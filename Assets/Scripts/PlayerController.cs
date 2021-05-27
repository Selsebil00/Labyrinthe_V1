using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    private Vector3 deplacement = Vector3.zero;
    [SerializeField]
    private float speedd = 4.0f, rot = 80f, current_Speed;

    [SerializeField]
    GameObject GameOverImage;

   

    void FixedUpdate()
    {
        // a noter que fixed update peut s'excuter 0 /1 ou plusieurs fois par image en fonction de nombre d'image physique par seconde 
        //physics frame per second 

        if(Input.GetKey(KeyCode.LeftControl))
        {
            current_Speed = speedd * 2;
        } else
        {
            current_Speed = speedd;
        }

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        float goForward = Input.GetAxis("Vertical");
        if(goForward > 0)
        {
            transform.Translate(Vector3.forward * current_Speed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        }
        
    }

    public void GameOver()
    {
        GameOverImage.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
