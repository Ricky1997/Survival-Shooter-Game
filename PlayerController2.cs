using UnityEngine;
using UnityEngine.Networking;

public class PlayerController2 : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			Fire();
		}
	}


	void Fire()
	{
		if (bulletPrefab.activeInHierarchy==true) {
			return;
		}
		bulletPrefab.SetActive (true);
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 9;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 1.5f);        
		bulletPrefab.SetActive (false);
	}
}