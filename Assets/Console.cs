using UnityEngine;
using System.Collections;

public class Console : MonoBehaviour {
	public static int nowIndex;
	public static GameObject nowConsole;
	public int initIndex;
	public GameObject[] set;
	public static GameObject[] texts;
	// Use this for initialization
	void Start () {
		Console.nowIndex = initIndex;
		Console.nowConsole = gameObject;
		texts = GameObject.FindGameObjectsWithTag ("text");
		texts [0].SetActive (false);
		texts [1].SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ResetTreasure()
	{
		for (int i = 0; i < set.Length; i++) 
		{
			set [i].SetActive (true);
			set [i].SendMessage ("SetTarget",false);
			set [i].SendMessage ("SetGazedAt",false);
		}
	}
}
