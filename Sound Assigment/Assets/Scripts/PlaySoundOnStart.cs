using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{

    [SerializeField] private AudioClip _clip;

    //Plays a sound when this script is started. Attached to the cube prefab.
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
    }

}
