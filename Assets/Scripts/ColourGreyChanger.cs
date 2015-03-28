using UnityEngine;
using System.Collections;

public class ColourGreyChanger : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		rend.material.SetColor("_Color", Color.grey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
