using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class OpenDoor : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            GameManager.nextStage = true;
        }
        
    }
}
