using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonObject : MonoBehaviour
{
    public UnityEvent OnButtonPressed;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
                OnButtonPressed.Invoke();       //이벤트를 발생시킨다                  
        }
    }

}
