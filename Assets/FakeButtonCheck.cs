using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FakeButtonCheck : MonoBehaviour
{
    public UnityEvent OnPressEvent;
    public static bool onOff;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnPressEvent.Invoke();           //이벤트를 실행시킨다.
                onOff = true;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                onOff = false;
            }
        }
    }
}
