using UnityEngine;
using System.Collections;

public class cameraClass : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void LateUpdate()		
	{
		transform.rotation = Quaternion.Euler(0, 180, 0.0f);
	}
}
