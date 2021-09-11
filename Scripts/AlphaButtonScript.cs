using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaButtonScript : MonoBehaviour {

	public float AlphaThreshold = 0.1f;
	// Use this for initialization
	void Start () {
		this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
