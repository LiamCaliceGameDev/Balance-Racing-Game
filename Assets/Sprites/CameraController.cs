using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;

	void FixedUpdate () {

		Vector3 targetPosition = target.position;
		targetPosition.z = -10;

		transform.position = targetPosition;

	}

}
