﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class sound
{
    // Start is called before the first frame update
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Range(.1f, 3f)]
    public float pitch;
    public string name;

    [HideInInspector]
    public AudioSource source;
}
