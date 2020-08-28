using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using System;
public class sound : MonoBehaviour
{
    public float Sound;
    [Range(0,1)]
    public float volume;
    [Range(0, 1)]
    public float clip;
    public AudioSource source;



}
