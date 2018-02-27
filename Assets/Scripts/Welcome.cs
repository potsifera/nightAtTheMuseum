using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Welcome : MonoBehaviour {

	public void Start(){
		gameObject.GetComponent<Renderer>().enabled = true;
	}
}
