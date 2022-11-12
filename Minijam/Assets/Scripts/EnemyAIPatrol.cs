using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class EnemyAIPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] movePoints;
    [SerializeField] private float speed = 5f;
    [SerializeField] private bool canMoveRight = false;
    [SerializeField] private float shootRange = 10f;
    [SerializeField] private LayerMask shootLayer;
    [SerializeField] private Transform aimTransform; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckCanMoveRight();
        MoveTowards();
    }

    private void MoveTowards()
    {
        if (canMoveRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[1].position, speed * Time.deltaTime);
            
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[0].position, speed * Time.deltaTime);
        }
    }

    private void Aim()
    {
        
    }
    private void CheckCanMoveRight()
    {
        if (Vector3.Distance(transform.position,movePoints[0].position) <= 0.1f)
        {
            canMoveRight = true;
            print("Move Right");
        }
        else if (Vector3.Distance(transform.position, movePoints[1].position) <= 0.1f)
        {
            canMoveRight = false;
            print("Move Left");
        }
    }



}
