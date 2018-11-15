using UnityEngine;
using System.Collections;

public class Hunt : MonoBehaviour {
	public GameObject[] treasureSets;
	public GameObject nextObject;
	public bool isTarget;
	public int myIndex;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Hunting(){
		if (Console.nowIndex == myIndex) {
			gameObject.SendMessage ("TeleportRandomly");
			gameObject.SetActive (false);
			Console.nowIndex++;
			if (Console.nowIndex == 7) 
			{
				Console.texts [0].SetActive (true);
				Console.texts [1].SetActive (true);
			}
		} else {
			Console.nowConsole.SendMessage ("ResetTreasure");
			Console.nowIndex = 0;
		}

	}
	public void SetTarget(bool value)
	{
		isTarget = value;
	}
}