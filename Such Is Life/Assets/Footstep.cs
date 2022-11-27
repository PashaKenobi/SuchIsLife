using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    [SerializeField] AudioSource walkAudio;
    // Start is called before the first frame update
    void WalkSound()
    {
        walkAudio.Play();
    }
}
