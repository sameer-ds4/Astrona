using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 0, 1), rotateSpeed);

        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 0, 1), -rotateSpeed);
    }
}