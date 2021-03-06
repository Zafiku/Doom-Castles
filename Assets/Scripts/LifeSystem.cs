﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour {
	public GameObject sangre;
	public GameObject blood;
	public int live = 100;
	public RectTransform livebar;
	
	private float rectLive; 
	public int maxLive;
	
	// Use this for initialization
	void Start () {
		if(livebar!=null){
			rectLive = livebar.rect.width / live;
		}
		maxLive = live;
	}
	
	// Update is called once per frame
	void Update () {
		if(live <=0){
			muerte();
			
		}
		
	}
	
	public void hurt(int damage){
		live = live - damage;
		if (live > maxLive) {
			live = maxLive;
		}
		var position = new Vector3 (transform.position.x, transform.position.y, -5);
		if(sangre != null){
			var clone = Instantiate(sangre,position,Quaternion.identity) as GameObject;
			clone.particleSystem.startColor =  Color.red;
			Destroy(clone,1);
		}
		
		if(blood != null){
			var clone2 =Instantiate(blood,transform.position,Random.rotation) as GameObject;
		}
		
		if(livebar!=null){
			livebar.sizeDelta = new Vector2( live*rectLive, livebar.rect.height);
		}
		
	}
	
	
	void muerte(){
		Destroy(gameObject);
	}
	/*
	void OnCollisionEnter2D(Collision2D target){
		
				if (target.transform.tag == tagDamage) {
					hurt(5);
				}
	}*/
	
	
}