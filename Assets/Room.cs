using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public GameObject bar;

    public void OpenDoor()
    {
        bar.SetActive(false);

    }

    public void CloseDoor()
    {
        bar.SetActive(true);
    }

}
