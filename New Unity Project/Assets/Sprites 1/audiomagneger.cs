using UnityEngine.Audio;
using UnityEngine;
using System;
public class audiomagneger : MonoBehaviour
{
    public sound[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            //s.source.clip = s.loop;
            //s.source.clip = s.volume;
            //s.source.volume = s.clip;
            //s.source.clip = s.pitch;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play(string name)
    {
        
    }
}
