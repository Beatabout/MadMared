using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMoover : MonoBehaviour
{
    
    [SerializeField] float moveSpeed = 2.5f;
    
    void Update()
    {
        transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;

        if(transform.position.x >= 25){
            Destroy(gameObject);
        }

    }
}
