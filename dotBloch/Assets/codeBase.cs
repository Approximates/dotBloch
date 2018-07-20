using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Numerics;

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

	public Slider thetaSlider;
	public Slider phiSlider;

	public Text quantumZeroLabel;
	public Text quantumOneLabel;
	public Text qubitLabel;

	public InputField thetaInputField;
	public InputField phiInputField;

	public bool isQuantumBitSelected;
	// Use this for initialization
	void Start () {
		thetaInputField.characterLimit = 6;
		phiInputField.characterLimit = 6;

		enableQuantumBit ();
		setBitsValues (true, 45, 0);
		//setBitsValues (true, 60, 280);
		setPointers ();

		thetaSlider.onValueChanged.AddListener(delegate {thetaSliderChanged(); });
		phiSlider.onValueChanged.AddListener(delegate {phiSliderChanged(); });
	}

	void thetaSliderChanged(){
		if (isQuantumBitSelected) {
			if (thetaValue != thetaSlider.value) { 
				thetaValue = thetaSlider.value;
			}
		} else {
			Debug.Log (thetaSlider.value);
		}

		setPointers ();
	}

	void phiSliderChanged(){
		if (isQuantumBitSelected) {
			if (phiValue != phiSlider.value) {
				phiValue = phiSlider.value;
			}
		}

		setPointers ();
	}
	


	public void setPointers(){
		if (isQuantumBitSelected) {
			this.thetaInputField.text = this.thetaValue.ToString ();
			this.phiInputField.text = this.phiValue.ToString ();

			thetaSlider.value = this.thetaValue;
			phiSlider.value = this.phiValue;

			quantumBitArrow.transform.rotation = Quaternion.Euler(this.thetaValue-90, this.phiValue, 0);

			//valueOfQuantumZero();
			quantumZeroLabel.text = valueOfQuantumZero();
			quantumOneLabel.text = valueOfQuantumOne();

			qubitLabel.text = valueOfQubit();
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
		phiSlider.wholeNumbers = true;

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

		setPointers ();
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

		phiInputField.interactable = false;
		phiInputField.text = "";

	}

	public String valueOfQuantumZero(){
		//Debug.Log (Math.Round(Math.Cos(this.thetaValue/2*Math.PI/180),3).ToString());
		return Math.Round(Math.Cos(this.thetaValue/2*Math.PI/180),3).ToString();
	}

	public String valueOfQuantumOne(){
		
		String result = "";

		result += Math.Round (Math.Cos (this.phiValue * Math.PI / 180) * Math.Sin (this.thetaValue / 2 * Math.PI / 180), 3).ToString ();
		result += " + " + Math.Round (Math.Sin (this.phiValue * Math.PI / 180) * Math.Sin (this.thetaValue / 2 * Math.PI / 180), 3).ToString () + "i"; 

		return result;
	}

	//qubitLabel
	public String valueOfQubit(){
		return "|" + "\u03A8".ToString () + "> = " + valueOfQuantumZero () + " |0> + " + valueOfQuantumOne () + " |1>";
			
	}

}
