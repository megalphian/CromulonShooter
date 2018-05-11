using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
	private GameObject bullet;
	private Rigidbody bullet_rb;
	public GameObject bulletGameObject;
	private GameObject player;

	private void Awake()
	{
		player = GameObject.FindWithTag("Player");
	}
    
	// Use this for initialization
	void Shoot()
    {
		bullet = Instantiate(bulletGameObject);
		bullet.transform.position = transform.position;
		bullet_rb = bullet.GetComponent<Rigidbody>();
		bullet_rb.velocity = player.transform.forward * 30;
		Destroy(bullet, 3f);
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			Shoot();
		}

    }
}
