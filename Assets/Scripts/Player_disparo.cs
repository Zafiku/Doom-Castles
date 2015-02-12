using UnityEngine;
using System.Collections;

public class Player_disparo : MonoBehaviour {

	public GameObject bala;
	public Transform puntoDisparo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
//			Debug.Log("HOLAAAA");
			var clone = Instantiate (bala, puntoDisparo.position,
			                         Quaternion.identity) as GameObject;
		}
	}
}

