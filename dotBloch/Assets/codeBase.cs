using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class codeBase : MonoBehaviour {

	//public float thetaValue;
	//public float phiValue;

	Qubit quantumBit;
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

	float FPSmilliseconds = 1;
	float millisecondsSinceLaunch = 0;
	int framesCount = 0;
	public Text FPSCounter;
	public Text millisecondsSinceLastFrame;

	public InputField thetaInputField;
	public InputField phiInputField;

	public bool isQuantumBitSelected;

	// Use this for initialization
	void Start () {
        /*quantumBit = new Qubit(5);
        Debug.Log("Phi angle:" + quantumBit.phiAngle);
        Debug.Log("Complex example:" + quantumBit.zero);
        Debug.Log("Real number of complex:" + quantumBit.zero.Real);
        Debug.Log("Imaginary numer of complex:" + quantumBit.zero.Imaginary);
        Debug.Log("Adding complex: " + quantumBit.add);
        Debug.Log("Multiplying complex: " + quantumBit.mul);*/
		quantumBit = new Qubit(45,0);
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
			if (quantumBit.thetaAngle != thetaSlider.value) { 
				quantumBit.thetaAngle = thetaSlider.value;
			}
		} else {
			Debug.Log (thetaSlider.value);
		}

		setPointers ();
	}

	void phiSliderChanged(){
		if (isQuantumBitSelected) {
			if (quantumBit.phiAngle != phiSlider.value) {
				quantumBit.phiAngle = phiSlider.value;
			}
		}

		setPointers ();
	}

	void framesPerSecond(ref float millisecondsLeft, ref int frames){

		millisecondsSinceLaunch += Time.deltaTime;
		millisecondsLeft -= Time.deltaTime;
		++frames;

		millisecondsSinceLastFrame.text = (Math.Round((double)Time.deltaTime*1000)).ToString() + " ms";



		if (millisecondsLeft <= 0) {
			FPSCounter.text = frames.ToString () + " FPS";

			if(frames<24) 
				FPSCounter.color = new Color32(255,0,0,255);

			if(frames>=24 || frames<58)
				FPSCounter.color = new Color32(255,255,0,255);

			if(frames>=58)
				FPSCounter.color = new Color32(0,255,0,255);

			millisecondsLeft = 1;
			frames = 0;
		}
	}
	


	public void setPointers(){
		if (isQuantumBitSelected) {
			this.thetaInputField.text = this.quantumBit.thetaAngle.ToString ();
			this.phiInputField.text = this.quantumBit.phiAngle.ToString ();

			thetaSlider.value = (float)this.quantumBit.thetaAngle;
			phiSlider.value = (float)this.quantumBit.phiAngle;

			quantumBitArrow.transform.rotation = Quaternion.Euler((float)this.quantumBit.thetaAngle-90, (float)this.quantumBit.phiAngle, 0);

			//valueOfQuantumZero();
			quantumZeroLabel.text = this.quantumBit.printZeroValue();
			quantumOneLabel.text = this.quantumBit.printOneValue(false);

			qubitLabel.text = this.quantumBit.printBlochVector();
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
		//this.phiValue = phiValue;
		//this.thetaValue = thetaValue;
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
		phiSlider.wholeNumbers = true;

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

	// public String valueOfQuantumZero(){
	// 	//Debug.Log (Math.Round(Math.Cos(this.thetaValue/2*Math.PI/180),3).ToString());
	// 	return Math.Round(Math.Cos(this.thetaValue/2*Math.PI/180),3).ToString();
	// }

	// public String valueOfQuantumOne(){
		
	// 	String result = "";

	// 	result += Math.Round (Math.Cos (this.phiValue * Math.PI / 180) * Math.Sin (this.thetaValue / 2 * Math.PI / 180), 3).ToString ();
	// 	result += " + " + Math.Round (Math.Sin (this.phiValue * Math.PI / 180) * Math.Sin (this.thetaValue / 2 * Math.PI / 180), 3).ToString () + "i"; 

	// 	return result;
	// }

	//qubitLabel
	// public String valueOfQubit(){
	// 	return "|" + "\u03A8".ToString () + "> = " + valueOfQuantumZero () + " |0> + " + valueOfQuantumOne () + " |1>";
			
	// }
	void Update()
	{
		framesPerSecond(ref FPSmilliseconds, ref framesCount);

		if (Input.GetKey(KeyCode.Escape))
		{
			 Application.Quit();
		}
	}
}
