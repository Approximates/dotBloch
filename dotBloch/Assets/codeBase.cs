using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBase : MonoBehaviour {

	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	public GameObject circleX;
	public GameObject circleY;
	public GameObject circleZ;
	public GameObject quantumBitOne;
	public GameObject quantumBitZero;
	public GameObject quantumBitArrow;




	// Use this for initialization
	void Start () {
		disableQuantumBit ();
		disableClassicalBit();

		enableClassicalBit ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void enableClassicalBit(){
		classicalOne.SetActive (true);
		classicalZero.SetActive (true);
		classicalBitArrow.SetActive(true);
	}

	public void disableClassicalBit(){
		classicalOne.SetActive (false);
		classicalZero.SetActive (false);
		classicalBitArrow.SetActive(false);
	}

	public void disableQuantumBit(){
		circleX.SetActive(false);
		circleY.SetActive(false);
		circleZ.SetActive(false);
		quantumBitOne.SetActive(false);
		quantumBitZero.SetActive(false);
		quantumBitArrow.SetActive(false);
	}
}
