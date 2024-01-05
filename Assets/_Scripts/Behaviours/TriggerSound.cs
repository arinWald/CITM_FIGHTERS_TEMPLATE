using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip HighQuick;
    public AudioClip HighSlow;
    public AudioClip LowQuick;
    public AudioClip LowSlow;
    public AudioClip BlockHigh;
    public AudioClip BlockLow;
    public AudioClip Die;
    public AudioClip Walk;
    private AudioSource audioSource;

    public Animator animator;
    private bool playedSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        if (state.IsName("HighQuick") && !playedSound)
        {
            audioSource.PlayOneShot(HighQuick);
            playedSound = true;
        }
        else if (!state.IsName("HighQuick"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("HighSlow") && !playedSound)
        {
            audioSource.PlayOneShot(HighSlow);
            playedSound = true;
        }
        else if (!state.IsName("HighSlow"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("LowQuick") && !playedSound)
        {
            audioSource.PlayOneShot(LowQuick);
            playedSound = true;
        }
        else if (!state.IsName("LowQuick"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("LowSlow") && !playedSound)
        {
            audioSource.PlayOneShot(LowSlow);
            playedSound = true;
        }
        else if (!state.IsName("LowSlow"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("BlockHigh") && !playedSound)
        {
            audioSource.PlayOneShot(BlockHigh);
            playedSound = true;
        }
        else if (!state.IsName("BlockHigh"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("BlockLow")  && !playedSound)
        {
            audioSource.PlayOneShot(BlockLow);
            playedSound = true;
        }
        else if (!state.IsName("BlockLow"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("Die") && !playedSound)
        {
            audioSource.PlayOneShot(Die);
            playedSound = true;
        }
        else if (!state.IsName("Die"))
        {
            playedSound = false;
        }
        //-------------------------------------------------------------------------------------
        if (state.IsName("WalkFront") && !playedSound)
        {
            audioSource.PlayOneShot(Walk);
            playedSound = true;
        }
        else if (!state.IsName("WalkFront"))
        {
            playedSound = false;
        }
        if (state.IsName("WalkBackwards") && !playedSound)
        {
            audioSource.PlayOneShot(Walk);
            playedSound = true;
        }
        else if (!state.IsName("WalkBackwards"))
        {
            playedSound = false;
        }
    }
}

