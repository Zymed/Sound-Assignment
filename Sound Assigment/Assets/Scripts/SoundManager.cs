using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Singleton class use as it is made as it can be use monobehavior
    public static SoundManager Instance;

    //The different adiosources can be added to these
    [SerializeField] private AudioSource _musicSource, effectsSource, nostalgiaSource;
    
    //Creates  the only instance of this object if there is none.
    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //A method that plays the roblox sound clip.
    public void PlaySound(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

    //A method that plays the nostalgia sound clip.
    public void PlayNostalgiaSound(AudioClip clip)
    {
        nostalgiaSource.PlayOneShot(clip);
    }

    //Creates a method to adjust the Master volume via. the slider.
    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    //Toggles the effect sounds (only roblox sound clip in this case, not used)
    public void ToggleEffects()
    {
        effectsSource.mute = !effectsSource.mute;
    }

    //Toggles the music sound
    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;
    }
}
