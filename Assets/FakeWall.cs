using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FakeWall : MonoBehaviour
{
    public Vector3 moveAmount;
    public float moveDuration = 1;
    private bool check = true;
 
    private void Start()
    {
        moveDuration = Random.Range(1f, 5f);
    }
    // Start is called before the first frame update
    IEnumerator enumerator()
    {

        while (true)
        {
            if (check == true)
            {          
                transform.DOLocalMove(moveAmount, moveDuration).SetRelative(true);
                yield return new WaitForSeconds(2f);
                check = false; 
            }
                if (check==false)
                {
                transform.DOLocalMove(moveAmount - 2 * moveAmount, moveDuration).SetRelative(true);
                yield return new WaitForSeconds(2f);
                check = true;
            }
            if (FakeButtonCheck.onOff == false)
            {
                break;
            }
        }
        StopAllCoroutines();
    }
    public void OpenDoor()
    {
        if (FakeButtonCheck.onOff == true)
        {
            StartCoroutine(enumerator());
        }
   
    }
}



