﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    Spaceship spaceship;

    IEnumerator Start()
    {
        spaceship = GetComponent<Spaceship>();

        while (true)
        {
            spaceship.Shot(transform);
            yield return new WaitForSeconds(spaceship.shotDelay);
        }
    }

	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        spaceship.Move(direction);

	}

    void OnTriggerEnter2D(Collider2D c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        if (layerName == "Bullet(Enemy)")
        {
            Destroy(c.gameObject);
        }

        if(layerName == "Bulelt(Enemy)"||layerName == "Enemy")
        {
            spaceship.Explosion();
            Destroy(gameObject);
        }
        
    }
}
