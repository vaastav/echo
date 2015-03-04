using UnityEngine;
using System.Collections;

public class MotionEnemy : MonoBehaviour {

	public GameObject target;
	public float speed;
	public float minDistance;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = transform.forward*speed;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("forward vector : " + transform.forward);
		Debug.Log ("rotation vector : " + transform.rotation);
		float distance = Vector3.Distance (transform.position, target.transform.position);
		Debug.Log ("Distance : " + distance); 
		if (distance > minDistance) {
						Vector3 targetAngle = Vector3.RotateTowards (transform.forward, target.transform.forward, Mathf.PI / 12, 0.0f);
						transform.rotation = Quaternion.LookRotation (target.transform.position - transform.position);
						Debug.Log ("Target Angle : " + targetAngle);
						rigidbody.velocity = transform.forward * speed;
				} else {
			rigidbody.velocity = Vector3.zero;
				}
	}
}
