using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPoen : MonoBehaviour
{
    // Button의 Player가 닿았을때
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
        }
    }
}
