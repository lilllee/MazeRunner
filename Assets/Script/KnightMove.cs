using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class KnightMove : MonoBehaviour
{
    public static KnightMove instance;
    public Transform firstPosition;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
       Vector3 first = transform.position;
    }
}
