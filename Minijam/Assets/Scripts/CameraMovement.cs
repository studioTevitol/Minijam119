using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Vector3   distance;
    [SerializeField] private GameObject  playerObj;
   
    
    void Start()
    {
        distance= transform.position-playerObj.transform.position;
    }

   
    void Update()
    {
       transform.position = playerObj.transform.position+distance;
    }
}
