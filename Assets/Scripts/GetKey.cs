using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{ //OnCollision
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameObject.Find("ExitPoint").GetComponent<DoorScript>().canOpen = true;
            GetComponent<AudioSource>().Play();
            Destroy(transform.parent.gameObject,t: 0.2f);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
