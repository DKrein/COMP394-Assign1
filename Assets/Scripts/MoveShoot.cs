using UnityEngine;
using System.Collections;

public class MoveShoot : MonoBehaviour {

	public float speed;

	void Start () {
		//GetComponent<Rigidbody2D>().velocity = transform * speed;
		GetComponent<Rigidbody2D> ().AddForce (transform.up * speed * 2);
	}
}
