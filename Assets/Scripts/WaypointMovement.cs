using UnityEngine;
using System.Collections;
using UnityEngine.Video;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;


	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	public Material playMaterial;

	//private bool moving = false;

	private GameObject atmosphericAudio;
	private AudioSource aAudio;
	private Object[] videos = {};
	private Object[] buttons = {};
	private VideoPlayer myVideo;
	private Renderer buttonRenderer; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(GameObject waypoint) {
		if (!teleport) {
			iTween.MoveTo (player, 
				iTween.Hash (
					"position", new Vector3 (waypoint.transform.position.x, waypoint.transform.position.y + height / 2, waypoint.transform.position.z), 
					"time", .2F, 
					"easetype", "linear"
				)
			);
		} else {
			player.transform.position = new Vector3 (waypoint.transform.position.x, 
                waypoint.transform.position.y + height / 2, 
                waypoint.transform.position.z);
		}

		//if atmospheric audio has stopped play when  moving to another waypoint
		atmosphericAudio = GameObject.Find ("AtmosphericAudio");
		aAudio = atmosphericAudio.GetComponent (typeof(AudioSource)) as AudioSource;

		if (!aAudio.isPlaying) {
			aAudio.Play ();
		}

		//get the gameObjects tagged with video 
		videos = GameObject.FindGameObjectsWithTag("Video");
		//loops through all the videos
		foreach(GameObject video in videos)
		{  //if the component inside eachobject is playing stop it
			myVideo = video.GetComponent<VideoPlayer> ();
			if (myVideo.isPlaying) {
				myVideo.Pause();
			}

		}

		//get the gameObjects tagged with videobutton
		buttons = GameObject.FindGameObjectsWithTag("VideoButton");
		foreach(GameObject button in buttons)
		{  //assign the playmaterial to all buttons
			
			buttonRenderer = button.GetComponent<Renderer> ();
			buttonRenderer.material = playMaterial;

		}
	}

}

