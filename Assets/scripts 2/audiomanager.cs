using UnityEngine.Audio;
using UnityEngine;
using System;
public class Audiomanager : MonoBehaviour
{
    public sound[] sounds; 
    // Start is called before the first frame update
    void Awake()
    { foreach(sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    // Update is called once per frame
    public void Play(string name)
    {
       sound s= Array.Find(sounds, sound => sound.name == name);
        if (s == null)
            return;
        s.source.Play(); 
    }
}
