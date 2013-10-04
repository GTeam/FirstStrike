using UnityEngine;
using System.Collections;

public class PlayerClass : MonoBehaviour {
	 

	public float speed = 2;
	public float nitro = 100;
	public float forceUp = 9.8f;
	public const float MaxForceUp = 15;
	public float forceForw = 5;
	// Use this for initialization
	
	
	float CalculateForceUp(float angle)
	{		print (angle);
		return (MaxForceUp - Mathf.Abs( 315 - angle) * (MaxForceUp / 45));		
	}
	void Start () {
	
	}
	void ChangeSpeed(){		
		
		float angolik = 0;
		Vector3 lol = Vector3.zero;
		transform.rotation.ToAngleAxis(out angolik,out lol);
		if(Vector3.Dot(transform.forward, Vector3.up) > 0f)
		{
			if(forceUp <= MaxForceUp  )
				forceUp = CalculateForceUp(angolik);		
		}
		else
		{
			if(forceUp > 0.31f)
			forceUp -= 0.3f;			
		}		
	}
	void FixedUpdate()		
	{	
		//rigidbody.AddRelativeForce(0,0,10,ForceMode.Acceleration);	
		rigidbody.AddRelativeForce(0, forceUp, forceForw);			
	}
	// Update is called once per frame
	void Update () {
	//inside the Update method
		ChangeSpeed();
			
		if(Input.GetKey("right"))
		{
		var right = Quaternion.Euler(1,0,0);
		transform.rotation *= right;	
			
		}
		if(Input.GetKey("left"))
		{
		var left = Quaternion.Euler(-1,0,0);
		transform.rotation *= left;	
			
		}
		
		if(Input.GetKey("up"))
		{
			if(forceForw < 30)
				forceForw += 0.1f;
		}
		if(Input.GetKey("down"))
		{
			if(forceForw > 1)
				forceForw -= 0.1f;	
		}
		
		

		//transform.Translate(0, 0, speed * Time.deltaTime);
		
		
	}
}
