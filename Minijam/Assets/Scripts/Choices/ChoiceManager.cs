using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceManager : MonoBehaviour
{
    public GameObject arm;
    public GameObject background;
    public GameObject player;
    public Camera cam;
    public GameObject black;
    public AudioSource audioSource;
   
    public void Nihilist()
    {
        arm.SetActive(false);
        background.SetActive(true);
        cam.transform.position = new Vector3(-8.05f,-1.55f,-10f);
        cam.orthographicSize = 1.45f;
        player.transform.position = new Vector3(-8.25f,-2.5f,0f);
        
        
    }
    public void Good()
    {  
        //To do
    }
    public void Bad()
    {
        //To do
    }
    public void PlaySovereign()
    {
        audioSource.Play();
	}
    public void switchBlack()
    {
        black.SetActive(true);
    }
    public void Credits()
    {
        
    }

}
