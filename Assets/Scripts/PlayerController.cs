using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float fireRate;
	public GameObject shot;
	public Transform shotSpawn;

	private Vector3 rotatePlayer;
	private float nextFire;

	void Update ()
	{
		if (Input.GetKey("space") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}

	void FixedUpdate () {
		float rotatePlayer = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		transform.Rotate(new Vector3 (0, 0,rotatePlayer * speed * 2 * -1));
		transform.Translate (new Vector3 (moveVertical * speed, 0, 0) * Time.deltaTime);

		if (transform.position.y > 5)
			transform.position = new Vector3 (transform.position.x, transform.position.y - 10, transform.position.z);
		else if (transform.position.y < -5)
			transform.position = new Vector3 (transform.position.x, transform.position.y + 10, transform.position.z);
		else if (transform.position.x > 5.3f)
			transform.position = new Vector3 (transform.position.x - 10.6f, transform.position.y, transform.position.z);
		else if (transform.position.x < -5.3f)
			transform.position = new Vector3 (transform.position.x + 10.6f, transform.position.y, transform.position.z);

	}
}
