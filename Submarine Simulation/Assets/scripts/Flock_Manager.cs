using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock_Manager : MonoBehaviour
{
	public Flock_Manager myManager;
	float speed;
	
	public GameObject fishPrefab;
	public int numFish = 20;
	public GameObject[] allFish;
	public Vector3 swimLimits = new Vector3(5, 5, 5);

	[Header("Fish Settings")]
	[Range(0.0f, 5.0f)]
	public float minSpeed;
	[Range(0.0f, 250.0f)]
	public float maxSpeed;

	void Start()
	{
		speed=Random.Range(myManager.minSpeed,myManager.maxSpeed);
		allFish = new GameObject[numFish];
		for (int i = 0; i < numFish; i++)
		{
			Vector3 pos = this.transform.position + new Vector3(Random.Range(-swimLimits.x, swimLimits.x),
																Random.Range(-swimLimits.y, swimLimits.y),
																Random.Range(-swimLimits.z, swimLimits.z));
			allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
			allFish[i].GetComponent<Flock_Manager>().myManager = this;
		}
	}

	void Update()
	{
		transform.Translate(0, 0, Time.deltaTime * speed);	
	}
}