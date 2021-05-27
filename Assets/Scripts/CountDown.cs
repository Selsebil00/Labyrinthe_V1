using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{


    [SerializeField]
    Text TxtTimer;
    [SerializeField]
    private int startCountdown = 60;


    void Start()
    {
        StartCoroutine(Pause());
    }

   IEnumerator Pause()
    {
        while(startCountdown > 0)
        {
            yield return new WaitForSeconds(1f);
            startCountdown--;
            TxtTimer.text = "Timer : " + startCountdown;
        }

        GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
    }
}
