using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBase : MonoBehaviour {

	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	// Use this for initialization
	void Start () {
		disableClassicalBit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void disableClassicalBit(){
		classicalOne.SetActive (false);
		classicalZero.SetActive (false);
		classicalBitArrow.SetActive(false);
	}
}
