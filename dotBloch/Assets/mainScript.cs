using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;

public class mainScript : MonoBehaviour {

	Qubit quantumBit;
	Qubit classicalBit;
	
	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	public GameObject circleX;
	public GameObject circleY;
	public GameObject circleZ;
	public GameObject quantumBitOne;
	public GameObject quantumBitZero;
	public GameObject quantumBitArrow;

	public GameObject ExitPanel;
	public Text ExitText;

	public Slider thetaSlider;
	public Slider phiSlider;

	public Text quantumZeroLabel;
	public Text quantumOneLabel;
	public Text qubitLabel;

	public Text FPSCounter;
	public Text millisecondsSinceLastFrame;

	public Text densityMatrix_0_0;
	public Text densityMatrix_0_1;
	public Text densityMatrix_1_0;
	public Text densityMatrix_1_1;

	public Text propabilityZero;
	public Text propabilityOne;

	public InputField thetaInputField;
	public InputField phiInputField;

	public bool isQuantumBitSelected;

	// Use this for initialization
	void Start () {
		quantumBit = new Qubit(45,0);
		classicalBit = new Qubit(0,0);
        thetaInputField.characterLimit = 6;
		phiInputField.characterLimit = 6;

		enableQuantumBit ();
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

	public void setPointers(){
		if (isQuantumBitSelected) {
			this.thetaInputField.text = this.quantumBit.thetaAngle.ToString ();
			this.phiInputField.text = this.quantumBit.phiAngle.ToString ();

			thetaSlider.value = (float)this.quantumBit.thetaAngle;
			phiSlider.value = (float)this.quantumBit.phiAngle;

			quantumBitArrow.transform.rotation = Quaternion.Euler((float)this.quantumBit.thetaAngle-90, (float)this.quantumBit.phiAngle, 0);

			quantumZeroLabel.text = this.quantumBit.print_zero_value();
			quantumOneLabel.text = this.quantumBit.print_one_value();

			densityMatrix_0_0.text = this.quantumBit.printDensityMatrix(0,0);
			densityMatrix_0_1.text = this.quantumBit.printDensityMatrix(0,1);
			densityMatrix_1_0.text = this.quantumBit.printDensityMatrix(1,0);
			densityMatrix_1_1.text = this.quantumBit.printDensityMatrix(1,1);

			propabilityOne.text = this.quantumBit.print_one_probability();
			propabilityZero.text = this.quantumBit.print_zero_probability();

			this.setTransparencyOfQuantumProbabilityLabels(quantumBit);

			qubitLabel.text = this.quantumBit.print_bloch_vector();
		} 
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
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			open_exit_panel();
		}
	}

	public void set_theta_angle(double sended_theta_angle){
        this.quantumBit.thetaAngle = sended_theta_angle;
        setPointers();
    }

    public void set_phi_angle(double sended_phi_angle){
        this.quantumBit.phiAngle = sended_phi_angle;
        setPointers();
    }

	private void open_exit_panel(){
		if (Application.platform != RuntimePlatform.WebGLPlayer){
			ExitPanel.SetActive(true);
			ExitText.text = Constants.message.exit_question;
		}
	}

	public void measureTheQubit()
	{	
		//Debug.Log("Probability |0>: " + quantumBit[0]);

		int zeroValue = Convert.ToInt32(Math.Round(quantumBit[0] * 10000));
		int measurementValue = Convert.ToInt32(Random.Range(1, 10000));

		//Debug.Log("Measurement value: " + measurementValue);

		quantumBit.phiAngle = 0;

		if(measurementValue >= zeroValue){
			quantumBit.thetaAngle = 180;
			Debug.Log("One!");
		}		
		else{
			quantumBit.thetaAngle = 0;
			Debug.Log("Zero!");
		}
		setPointers();
	}

	public void switchBit(){
		if(isQuantumBitSelected)
		{
			isQuantumBitSelected = false;
			disableQuantumBit();
			enableClassicalBit();
			setPointers();
			Debug.Log("Classical bit is selected");
		}
		else
		{
			isQuantumBitSelected = true;
			disableClassicalBit();
			enableQuantumBit();
			setPointers();
			Debug.Log("Quantum bit is selected");
		}
	}

	private void setTransparencyOfQuantumProbabilityLabels(Qubit quantumBit)
	{
		byte zeroTransparency =  Convert.ToByte(80 + Math.Round(quantumBit[0]*120));
		byte oneTransparency = Convert.ToByte(80 + Math.Round(quantumBit[1]*120));

		propabilityZero.color = new Color32(255,255,255,zeroTransparency);
		propabilityOne.color = new Color32(255,255,255,oneTransparency);
	}
}
