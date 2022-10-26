/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified: Aidan Pohl
 * ModOn: 10/26/2022
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioSrc;
    AudioClip audClip;



    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        audClip = audioSrc.clip;

    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

public void playCackle()
    {
        audioSrc.PlayOneShot(audClip);
    }





}
