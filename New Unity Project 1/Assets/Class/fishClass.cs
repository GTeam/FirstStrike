using UnityEngine;
using System.Collections;

public class fishClass : MonoBehaviour {
	
	public float speed = 6f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < -6 || transform.position.x > 40) {
			//turn around
			transform.Rotate(new Vector3(0,180,0));
			int height = Random.Range(-2,2);

			if(transform.position.y >= 18 && height > 0){
				transform.Translate( new Vector3(0, transform.position.y - height,0) );
			}
				
			
			transform.Translate( new Vector3(0, transform.position.y + height,0) );

//get new speed
			speed = Random.Range(6f,10f);
		}
		transform.Translate( new Vector3(-speed*Time.deltaTime,0,0) );
	}
}
