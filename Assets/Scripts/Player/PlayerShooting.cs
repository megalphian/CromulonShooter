using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
	private GameObject bullet;
	private Rigidbody bullet_rb;
	private float bulletLifeTime = 2f;
	private float speedFactor = 30f;

	private Transform GunPosition;

	[SerializeField] private GameObject bulletGameObject;

    //Get the gun child from the Tree
	private void Awake()
	{
		GunPosition = gameObject.transform.GetChild(0);
	}
    
	// Handles Shooting of the Projectile
	void Shoot()
    {
		bullet = Instantiate(bulletGameObject); //Create Bullet
		bullet.transform.position = GunPosition.position; //Create bullet in the orientation of the gun
		bullet_rb = bullet.GetComponent<Rigidbody>(); //Get the Physics component of the bullet
		bullet_rb.velocity = transform.forward * speedFactor; //Give inital velocity to the bullet
		Destroy(bullet, bulletLifeTime); //Destroy bullet after 
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			Shoot();
		}

    }
}
