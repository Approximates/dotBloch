using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeBase : MonoBehaviour {

	public float thetaValue;
	public float phiValue;
	public bool bitValue;

	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	public GameObject circleX;
	public GameObject circleY;
	public GameObject circleZ;
	public GameObject quantumBitOne;
	public GameObject quantumBitZero;
	public GameObject quantumBitArrow;

	public Button switchToClassicalBit;
	public Button switchToQuantumBit;

	public Slider thetaSlider;
	public Slider phiSlider;

	public InputField thetaInputField;
	public InputField phiInputField;

	public bool isQuantumBitSelected;
	// Use this for initialization
	void Start () {
		thetaInputField.characterLimit = 6;
		phiInputField.characterLimit = 6;

		enableQuantumBit ();
		setBitsValues (true, 120, 270);
		setPointers ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setPointers(){

		if (isQuantumBitSelected) {
			this.thetaInputField.text = this.thetaValue.ToString ();
			this.phiInputField.text = this.phiValue.ToString ();

			thetaSlider.value = this.thetaValue;
			phiSlider.value = this.phiValue;

			quantumBitArrow.transform.rotation = Quaternion.Euler(this.thetaValue-90, this.phiValue, 0);

		} else if (bitValue) {
			this.thetaInputField.text = "1";
			this.phiInputField.text = "";

			thetaSlider.value = 1;
			phiSlider.value = 0;

			classicalBitArrow.transform.rotation = Quaternion.Euler(-90, 0, 0);
		} else {
			this.thetaInputField.text = "0";
			this.thetaInputField.text = "";

			thetaSlider.value = 0;
			phiSlider.value = 0;

			classicalBitArrow.transform.rotation = Quaternion.Euler(90, 0, 0);
		}
			
	}

	public void setBitsValues(bool bitValue, float thetaValue, float phiValue){
		this.bitValue = bitValue;
		this.phiValue = phiValue;
		this.thetaValue = thetaValue;
	}

	public void enableClassicalBit(){
		disableQuantumBit ();

		isQuantumBitSelected = false;

		classicalOne.SetActive (true);
		classicalZero.SetActive (true);
		classicalBitArrow.SetActive(true);

		thetaSlider.maxValue = 1;
		phiSlider.interactable = false;
		thetaSlider.wholeNumbers = true;

		switchToClassicalBit.GetComponent<Image>().color = Color.yellow; 

		setPointers ();
	}

	public void enableQuantumBit(){
		disableClassicalBit();

		isQuantumBitSelected = true;

		circleX.SetActive(true);
		circleY.SetActive(true);
		circleZ.SetActive(true);
		quantumBitOne.SetActive(true);
		quantumBitZero.SetActive(true);
		quantumBitArrow.SetActive(true);

		thetaSlider.maxValue = 180;
		phiSlider.interactable = true;
		thetaSlider.wholeNumbers = false;
		phiInputField.interactable = true;

		switchToQuantumBit.GetComponent<Image>().color = Color.yellow; 

		setPointers ();
	}

	public void disableClassicalBit(){

		classicalOne.SetActive (false);
		classicalZero.SetActive (false);
		classicalBitArrow.SetActive(false);

		switchToClassicalBit.GetComponent<Image>().color = Color.white; 
	}

	public void disableQuantumBit(){
		circleX.SetActive(false);
		circleY.SetActive(false);
		circleZ.SetActive(false);
		quantumBitOne.SetActive(false);
		quantumBitZero.SetActive(false);
		quantumBitArrow.SetActive(false);

		phiInputField.interactable = false;

		switchToQuantumBit.GetComponent<Image>().color = Color.white;
	}
}
