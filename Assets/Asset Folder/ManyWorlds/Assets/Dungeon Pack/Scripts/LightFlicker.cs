using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class LightFlicker : MonoBehaviour
{
	public float minIntensity = 0.1f;
	public float maxIntensity = 0.5f;
	private float flicker = 0.1f;
	private float nextTime = 0.0f;
	private float currIntensity = 0.1f;

	
	void Start()
	{

	}
	void GetNextFlicker()
	{
		flicker = Random.Range (0.1f, 0.5f);
		currIntensity = Random.Range (minIntensity, maxIntensity);
	}
	
	void Update()
	{
		GetComponent<Light>().intensity = Mathf.Lerp (minIntensity, currIntensity, nextTime);

		nextTime += Time.deltaTime;
		if (nextTime >= flicker) 
		{
			nextTime = 0.0f;
			GetNextFlicker ();
		}

	}
}