using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class AroomC : MonoBehaviour
{
    //public Vector3 moveAmount;
    public Vector3 boxPosition;
    public Vector3 point;
    public GameObject target;
    public GameObject box;
    public float moveDuration = 1;
    public GameObject onText;

    private void Start()
    {
        point = target.transform.localPosition;
        boxPosition = box.transform.localPosition;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.DOLocalMove(point - boxPosition, moveDuration).SetRelative(true);
            }
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Answer")
        {
            print("it is Answer");
            onText.SetActive(true);
        }
    }
}