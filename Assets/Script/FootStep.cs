using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    CharacterController characterFootStep;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        characterFootStep = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterFootStep.isGrounded == true && characterFootStep.velocity.magnitude > 2f && audio.isPlaying ==false )
        {
           
            audio.volume = Random.Range(0.8f, 1f);
            audio.pitch = Random.Range(0.8f, 1.3f);
            audio.Play();
            if (Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.D))
            {
                audio.Stop();
            }
        }
    }
}
