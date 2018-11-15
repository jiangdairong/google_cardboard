using UnityEngine;
using System.Collections;

public class AR_Cam : MonoBehaviour {
	public Renderer myRenderer;
	private WebCamTexture mCamera;
	// Use this for initialization
	void Start () {
		mCamera = new WebCamTexture ();
		myRenderer.material.mainTexture = mCamera;
		mCamera.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
