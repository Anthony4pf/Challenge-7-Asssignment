using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Audio;


public class Audiomanager : MonoBehaviour
{
	private Scene scene;
	public Sound[] sounds;

	public static Audiomanager instance;
	AudioSource MyAudioSource;
    
    void Awake()
    {
		MyAudioSource = GetComponent<AudioSource>();
		scene = SceneManager.GetActiveScene();

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
			s.source.loop = s.loop;
		}
    }
	void Start()
	{
		Play("Theme");
	}

	public void Play (string name)
	{
		if(GameManager.mute)
		return;
		
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if(s == null)
			return;
		s.source.Play();
	}
}
