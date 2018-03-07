using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseUI : MonoBehaviour {

	public WorldSpaceVideo worldSpaceVideo;

	public void ClickCube()
	{
		worldSpaceVideo.PlayPause();
	}
	
}
