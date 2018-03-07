using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour {

	public Material playButtonMaterial;
	public Material pauseButtonMaterial;
	public Renderer buttonRenderer;

	private VideoPlayer videoPlayer;
	private GameObject atmosphericAudio;
	private AudioSource aAudio;

	private void Awake() {
		videoPlayer = GetComponent<VideoPlayer>();
		atmosphericAudio = GameObject.Find ("AtmosphericAudio");
		aAudio = atmosphericAudio.GetComponent (typeof(AudioSource)) as AudioSource;

	}

	public void PlayPause() {
		if (videoPlayer.isPlaying) {
			videoPlayer.Pause();
			buttonRenderer.material = playButtonMaterial;
			aAudio.Play ();
		} else {
			videoPlayer.Play();
			buttonRenderer.material = pauseButtonMaterial;
			aAudio.Pause ();
		}
	}


}
