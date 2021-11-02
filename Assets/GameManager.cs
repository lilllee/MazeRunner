using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static bool canPlayerMove = true;  //플레이어 움직임 제어

    public static bool nextCamera = false;    //다음 카메라

    public static bool nextStage = false;     //초기 애니메이션


    public Transform exitDoor;
    public Transform blackKing;
    private AudioSource audioSource;

   // Animation animation;                      //문열리는 애니메이션
    // Update is called once per frame
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (nextCamera)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canPlayerMove = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canPlayerMove = true;
        }
        if (nextStage == true)
        {
            exitDoor.DOLocalRotate(new Vector3(exitDoor.localEulerAngles.x,exitDoor.localEulerAngles.y - 90, exitDoor.localEulerAngles.z), 2f);
            blackKing.DOLocalRotate(new Vector3(blackKing.localEulerAngles.x +90, blackKing.localEulerAngles.y, blackKing.localEulerAngles.z), 2f);
            audioSource.Play();
            nextStage = false;

        }
    } 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


}
