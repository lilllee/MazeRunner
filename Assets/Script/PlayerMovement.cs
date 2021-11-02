using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController charController;
    private Rigidbody rigid;
    private Vector3 vector;
    public float speed;                         //player speed
    public GameObject[] chessKnights;           //나이트
    public Transform[] chessPinPoints;          //놓을수 있는곳의 스팟
    public GameObject cameras;
    public GameObject cameras1;
    public Text pressE;                         //E를 눌러라 같은 텍스트 올리게 하는거
    public GameObject clear;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        charController = GetComponent<CharacterController>();
        clear.SetActive(false);
      
    }
    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal")*-speed;
        float v = Input.GetAxis("Vertical")*speed;
        if (GameManager.canPlayerMove)
        {
            Move(h, v);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameManager.nextCamera = false;
            cameras.SetActive(true);
            cameras1.SetActive(false);
            pressE.text = "";
        }
    }

    IEnumerator DelayTime()
    {
        clear.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("JailStage");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chess")               //간판에 닿으면 pressE 텍스트를 'PRESS E'로 바꿈
        {
            pressE.text = "PRESS  E";
        }
        if (other.tag == "Door")                //밖으로 나가면 화면 조지고 
        {
            StartCoroutine(DelayTime());
        }
    }

    private void OnTriggerStay(Collider other)    
    {
        if (other.tag=="Chess")                   //chess판 collider tag안에 있을시
        {
            if (Input.GetKeyDown(KeyCode.E))      //E button 클릭시
            {
                ChessBoard();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chess")
        {
            pressE.text = "";
        }
    }

    public void Move(float h, float v) {

        Vector3 forwardMovement = transform.forward * -h;
        Vector3 rightMovement = transform.right * -v;
        charController.SimpleMove(forwardMovement + rightMovement);
    }
    private void ChessBoard()
    {
        GameManager.nextCamera = true;
        cameras.SetActive(false);
        cameras1.SetActive(true);
        pressE.text = "PRESS R TO OUT";
    }
}