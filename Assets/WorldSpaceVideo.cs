using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour {

	public Material playButtonMaterial;
	public Material pauseButtonMaterial;
	public Renderer buttonRenderer;

	private VideoPlayer videoPlayer;

	private void Awake() {
		videoPlayer = GetComponent<VideoPlayer>();

	}

	public void PlayPause() {
		if (videoPlayer.isPlaying) {
			videoPlayer.Pause();
			buttonRenderer.material = playButtonMaterial;
		} else {
			videoPlayer.Play();
			buttonRenderer.material = pauseButtonMaterial;
		}
	}


}
