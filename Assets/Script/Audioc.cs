using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioc : MonoBehaviour
{
    AudioSource audioController;
    // Start is called before the first frame update
    void Awake()
    {
        audioController = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioController.volume = Random.Range(0.8f, 1.1f);
    }
}
