using UnityEngine;
using System.Collections;

public class WaypointMovement : MonoBehaviour {
	
	public GameObject player;


	public float height = 2;
	public bool teleport = true;

	public float maxMoveDistance = 10;
	private bool moving = false;

	private GameObject atmosphericAudio;
	private AudioSource aAudio;


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
	}

}

