using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public int speed = 10;

    public float lifetime = 5;


	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        Destroy(gameObject, lifetime);
	}

}
