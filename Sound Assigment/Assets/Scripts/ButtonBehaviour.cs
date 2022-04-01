using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{

    public Button spawnButton, toggleButton, nostalgiaButton;

    [SerializeField] private bool _toggleMusic, toggleEffects;

    [SerializeField] private GameObject cube;

    [SerializeField] private AudioClip nostalgia;
    
    // Adding add listener to every button in order to execute desired method.
    void Start()
    {
        spawnButton.onClick.AddListener(SpawnObject);
        toggleButton.onClick.AddListener(ToggleSounds);
        nostalgiaButton.onClick.AddListener(PlayNostalgia);
    }
    //Toggle function that can toggle either the effect sounds og music. Only music is used in this project.
    public void ToggleSounds()
    {
        if (toggleEffects) SoundManager.Instance.ToggleEffects();
        if (_toggleMusic) SoundManager.Instance.ToggleMusic();
    }
    //instantiates the cube, that has the PlaySoundOnStart script attached.
    private void SpawnObject()
    {
        Instantiate(cube);
    }

    //Plays the nostalgia sound clip
    private void PlayNostalgia()
    {
        SoundManager.Instance.PlayNostalgiaSound(nostalgia);
    }
}
