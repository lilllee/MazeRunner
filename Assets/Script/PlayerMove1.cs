using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove1 : MonoBehaviour
{
    private CharacterController charController;
    private Rigidbody rigid;
    private Vector3 vector;
    public float speed;                         //player speed
    public Transform warp;
    public Transform warp2;
    public GameObject clear;
    public GameObject[] setAct;

    void Awake()
    {

        rigid = GetComponent<Rigidbody>();
        charController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * speed;
        float v = Input.GetAxis("Vertical") * speed;
        Move(h, v);
    }

    private void Move(float h, float v)
    {
        print("Move");

        Vector3 forwardMovement = transform.forward * v;
        Vector3 rightMovement = transform.right * h;
        charController.SimpleMove(forwardMovement + rightMovement);
    }
    IEnumerator DelayTime()
    {
        clear.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Quiz");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")                //밖으로 나가면 코루틴
        {
            StartCoroutine(DelayTime());
        }
        if (other.tag == "Warp")
        {
            Destroy(setAct[0]);
            Destroy(setAct[1]);
            charController.Move(warp.position - transform.position);
            charController.Move(warp2.position - transform.position);
            //transform.position = ;
        }
    }
}
