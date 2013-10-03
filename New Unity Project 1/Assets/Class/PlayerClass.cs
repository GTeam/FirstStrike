using UnityEngine;
using System.Collections;

public class PlayerClass : MonoBehaviour {
	 private float force;

//    public float speed;
//
//    public Vector3 rotSpeedMult = new Vector3(5f, 5f, 10f);
//
//    public float rotSpeedMax = 45f;
//
//    private Quaternion newRotation;
//
//    private Vector3 inpDamp;
//        
//    void Start()
//    {
//        Screen.lockCursor = !Screen.lockCursor;
//    }
//
//        void Update ()
//        {
//            inpDamp += new Vector3(
//
//                -Input.GetAxis("Mouse Y")*rotSpeedMult.x*Time.deltaTime,
//
//                Input.GetAxis("Mouse X")*rotSpeedMult.y*Time.deltaTime,
//
//                -Input.GetAxis("Horizontal")*rotSpeedMult.z*Time.deltaTime);
//
//        inpDamp.x = Mathf.Clamp(inpDamp.x, -180f, 180f);
//        inpDamp.y = Mathf.Clamp(inpDamp.y, -180f, 180f);
//        inpDamp.z = Mathf.Clamp(inpDamp.z, -180f, 180f);
//
//
//            newRotation = Quaternion.Euler(inpDamp);
//
//            transform.rotation = Quaternion.RotateTowards(transform.rotation, transform.rotation*newRotation,
//                                                          rotSpeedMax*Time.deltaTime);
//            inpDamp = Vector3.Lerp(inpDamp,Vector3.zero,3f*Time.deltaTime);
//
//            force = Input.GetAxis("Vertical");
//
//        if(Input.GetKeyDown(KeyCode.F1))
//            Screen.lockCursor = !Screen.lockCursor;
//        }
//
//    void FixedUpdate()
//    {
//        rigidbody.AddRelativeForce(Vector3.forward*(force*speed),ForceMode.Acceleration);
//    }
	public float speed = 2;
	public float nitro = 100;
	// Use this for initialization
	void Start () {
	
	}
	void ChangeSpeed(){
		
		//float dot = Vector3.Dot(transform.forward, Vector3.up);//1-направлен вверх, -1-направлен вниз, 0-направлен вбок.
//bool upOrDn = dot > 0f;
		
		if(Vector3.Dot(transform.forward, Vector3.up) > 0f)
		{
			if(speed >= 0.1f)
					speed -= 0.1f;
		}
		else
		{
			if(speed < 15)
				speed += 0.1f;
			
			
		}
//			if(transform.rotation.x < 90 && transform.rotation.x > 0 ){
//				if(speed >= 0.1f)
//					speed -= 0.1f;
//			}
//			else {
//			if(speed < 15)
//				speed += 0.1f;
//			}
		
			
		
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
		
//		if(Input.GetKey("left"))
//		{
//				
//			transform.Rotate(0,0f,3f);
//				//transform.Rotate(new Vector3( 3, 0, 0));
//			//return;
//		}
//		if(Input.GetKey("right")) {
//			
//			transform.Rotate(0,0f,-3f);
//			//transform.Rotate(new Vector3( -3, 0, 0));
//		}
//		if(Input.GetKey("up") && speed < 15 && nitro > 1) {
//			speed += 0.5f;
//			nitro--;
//		}
//		
//		if(Input.GetKey("down") && speed < 15) {
//			//speed += 0.1f;
//		}
		/*if (transform.position.x > 40) {
			//get new speed
			//speed = Random.Range(8f,12f);
			transform.position = new Vector3( -6f, transform.position.y, transform.position.z );
			
		
		}*/
		transform.Translate(0, 0, speed * Time.deltaTime);
	}
}
