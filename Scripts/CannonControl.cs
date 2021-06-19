using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
	public GameObject prefabBullet;
    public Transform target;
    public float vertCoof;
    public float horCoof;

	private void Start() {
		Invoke(nameof(Shoot), 1);
	}

	private void Shoot(){
		GameObject bullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
		Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();

		Vector2 side = (target.position - transform.position).normalized;

		rbBullet.AddForce(side * horCoof + Vector2.up * vertCoof,
		ForceMode2D.Impulse);


		Debug.DrawRay(transform.position, side * horCoof, Color.black, 1);
		Debug.DrawRay(transform.position, Vector3.up * vertCoof, Color.blue, 1);

		Debug.DrawRay(transform.position, side * horCoof + Vector2.up * vertCoof, Color.red, 1);

		Invoke(nameof(Shoot), 1);
	}
}
