using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
	private AudioSource source;

	private void OnEnable()
	{
		source = GameObject.Find("Audio Source").GetComponent<AudioSource>();
	}

	public void PlayOneShot(AudioClip clip)
	{
		source.PlayOneShot(clip);
	}
}