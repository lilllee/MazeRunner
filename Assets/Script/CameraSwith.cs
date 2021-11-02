using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwith : MonoBehaviour
{
    public GameObject cameras;
    public GameObject cameras1;                  

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameManager.nextCamera = true;
            cameras.SetActive(false);
            cameras1.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameManager.nextCamera = false;
            cameras.SetActive(true);
            cameras1.SetActive(false);
        }
    }
}
