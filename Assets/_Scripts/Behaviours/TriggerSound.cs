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

    // Boolean variables for each animation state
    private bool isHighQuickPlayed;
    private bool isHighSlowPlayed;
    private bool isLowQuickPlayed;
    private bool isLowSlowPlayed;
    private bool isBlockHighPlayed;
    private bool isBlockLowPlayed;
    private bool isDiePlayed;
    private bool isWalkPlayed;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);

        // Check and play sound for HighQuick animation
        if (state.IsName("HighQuick") && !isHighQuickPlayed)
        {
            audioSource.PlayOneShot(HighQuick);
            isHighQuickPlayed = true;
        }
        else if (!state.IsName("HighQuick"))
        {
            isHighQuickPlayed = false;
        }

        // Check and play sound for HighSlow animation
        if (state.IsName("HighSlow") && !isHighSlowPlayed)
        {
            audioSource.PlayOneShot(HighSlow);
            isHighSlowPlayed = true;
        }
        else if (!state.IsName("HighSlow"))
        {
            isHighSlowPlayed = false;
        }


        // Check and play sound for LowQuick animation
        if (state.IsName("LowQuick") && !isLowQuickPlayed)
        {
            audioSource.PlayOneShot(LowQuick);
            isLowQuickPlayed = true;
        }
        else if (!state.IsName("LowQuick"))
        {
            isLowQuickPlayed = false;
        }

        // Check and play sound for LowSlow animation
        if (state.IsName("LowSlow") && !isLowSlowPlayed)
        {
            audioSource.PlayOneShot(LowSlow);
            isLowSlowPlayed = true;
        }
        else if (!state.IsName("LowSlow"))
        {
            isLowSlowPlayed = false;
        }

        // Check and play sound for BlockHigh animation
        if (state.IsName("BlockHigh") && !isBlockHighPlayed)
        {
            audioSource.PlayOneShot(BlockHigh);
            isBlockHighPlayed = true;
        }
        else if (!state.IsName("BlockHigh"))
        {
            isBlockHighPlayed = false;
        }

        // Check and play sound for BlockLow animation
        if (state.IsName("BlockLow") && !isBlockLowPlayed)
        {
            audioSource.PlayOneShot(BlockLow);
            isBlockLowPlayed = true;
        }
        else if (!state.IsName("BlockLow"))
        {
            isBlockLowPlayed = false;
        }


        // Check and play sound for Die animation
        if (state.IsName("Die") && !isDiePlayed)
        {
            audioSource.PlayOneShot(Die);
            isDiePlayed = true;
        }
        else if (!state.IsName("Die"))
        {
            isDiePlayed = false;
        }

        // Check and play sound for Walk animation
        if ((state.IsName("WalkFront") || state.IsName("WalkBackwards")) && !isWalkPlayed)
        {
            audioSource.PlayOneShot(Walk);
            isWalkPlayed = true;
        }
        else if (!(state.IsName("WalkFront") || state.IsName("WalkBackwards")))
        {
            isWalkPlayed = false;
        }
    }
}
