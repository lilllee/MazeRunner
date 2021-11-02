using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    public Transform[] position;
    private void Awake()
    {

    }

    void OnMouseDown()                  //클릭할때 넘어가는 함수
    {
        KnightMove.instance.transform.DOMove(transform.position, 2f).SetEase(Ease.InOutQuad);//.OnComplete(ArriveOnTitle);
    }
  
    /* void ArriveOnTitle()
     {
         KnightMove.instance.transform.DOShakeScale(0.5f);
     }*/
}
