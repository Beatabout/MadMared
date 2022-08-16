using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoover : MonoBehaviour
{
    [SerializeField] Transform[] playerPathPoint;
    [SerializeField] float moveSpeed = 2;

    Vector2 target;
    Vector2 currentPosition;

    int index = 1;

    void Start() {
        target = playerPathPoint[index].position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(index > 0){
                index -=1;
                target = playerPathPoint[index].position;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(index < playerPathPoint.Length - 1){
                index +=1;
                target = playerPathPoint[index].position;
            }
        }

        currentPosition = transform.position;

        if(Vector2.Distance(currentPosition, target) > 0f){
            transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed*Time.deltaTime);
        }
        
    }
}
