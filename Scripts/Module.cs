using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour
{
	private void FixedUpdate() {
		Debug.Log($"������ ������� {transform.position.magnitude}, ������� ������ {transform.position.sqrMagnitude}, ����������� ������� {transform.position.normalized}");
		
		Debug.DrawRay(Vector3.zero, transform.position,Color.black);
	}
}
