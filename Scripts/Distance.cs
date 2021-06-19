using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform circle;
    public Transform square;

	private void FixedUpdate() {
		float distance1 = (circle.position - square.position).magnitude;
		float distance2 = Vector3.Distance(circle.position, square.position);
		float distance3 = Vector2.Distance(circle.position, square.position);

		Debug.DrawRay(Vector3.zero, circle.position, Color.green);
		Debug.DrawRay(Vector3.zero, square.position, Color.red);
		
		Debug.DrawRay(square.position, (circle.position - square.position), Color.black);

		Debug.Log($"����������: {distance1}, {distance2}, {distance3}");
	}
}
