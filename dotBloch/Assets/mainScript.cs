using UnityEngine;
using UnityEngine.UI;
using System;
using Random=UnityEngine.Random;

public class mainScript : MonoBehaviour {

	Qubit quantumBit;

	Bit classicalBit;
	
	public GameObject classicalOne;
	public GameObject classicalZero;
	public GameObject classicalBitArrow; 

	public GameObject circleX;
	public GameObject circleY;
	public GameObject circleZ;
	public GameObject quantumBitOne;
	public GameObject quantumBitZero;
	public GameObject quantumBitArrow;

	public GameObject theta30DegreeButton;
	public GameObject theta60DegreeButton;
	public GameObject theta90DegreeButton;
	public GameObject theta120DegreeButton;
	public GameObject theta150DegreeButton;
	public GameObject phi0DegreeButton;
	public GameObject phi60DegreeButton;
	public GameObject phi120DegreeButton;
	public GameObject phi180DegreeButton;
	public GameObject phi240DegreeButton;
	public GameObject phi300DegreeButton;
	public GameObject phi360DegreeButton;
	public GameObject ExitPanel;

	public GameObject densityMatrix;
	public Text ExitText;

	public Slider thetaSlider;
	public Slider phiSlider;

	public Text quantumZeroLabel;
	public Text quantumOneLabel;
	public Text qubitLabel;

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
		classicalBit = new Bit(true);
        thetaInputField.characterLimit = 6;
		phiInputField.characterLimit = 6;

		enableQuantumBit ();
		setPointers ();

		setListenersForSliders();
	}

	private void setListenersForSliders(){
		thetaSlider.onValueChanged.AddListener(delegate {thetaSliderChanged(); });
		phiSlider.onValueChanged.AddListener(delegate {phiSliderChanged(); });
	}

	private void disableListenersForSliders(){
		thetaSlider.onValueChanged.RemoveAllListeners();
		phiSlider.onValueChanged.RemoveAllListeners();
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
		if (isQuantumBitSelected){
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
		}else{
			

			Debug.Log("Stan bitu kwantowego " + classicalBit.getState());
			if(classicalBit.getState()=="1")
				thetaSlider.value = 0;
			else
				thetaSlider.value = 180;

			propabilityZero.text = this.classicalBit.getZeroProbability();
			propabilityOne.text = this.classicalBit.getOneProbability();		

			thetaInputField.text = thetaSlider.value.ToString();
			phiSlider.value = 0;
			phiInputField.text = phiSlider.value.ToString();

			classicalBitArrow.transform.rotation = Quaternion.Euler((float)this.thetaSlider.value-90, (float)this.phiSlider.value, 0);
		}
			
		 Debug.Log("setPointers here!");
	}

	public void enableClassicalBit(){
		disableQuantumBit ();

		isQuantumBitSelected = false;

		classicalOne.SetActive (true);
		classicalZero.SetActive (true);
		classicalBitArrow.SetActive(true);

		theta30DegreeButton.SetActive(false);
		theta60DegreeButton.SetActive(false);
		theta90DegreeButton.SetActive(false);
		theta120DegreeButton.SetActive(false);
		theta150DegreeButton.SetActive(false);

		phi0DegreeButton.SetActive(false);
		phi60DegreeButton.SetActive(false);
		phi120DegreeButton.SetActive(false);
		phi180DegreeButton.SetActive(false);
		phi240DegreeButton.SetActive(false);
		phi300DegreeButton.SetActive(false);
		phi360DegreeButton.SetActive(false);

		thetaSlider.interactable = false;
		phiSlider.interactable = false;
		thetaSlider.wholeNumbers = true;

		densityMatrix.SetActive(false);
		setTransparencyOfClassicalProbability();
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

		theta30DegreeButton.SetActive(true);
		theta60DegreeButton.SetActive(true);
		theta90DegreeButton.SetActive(true);
		theta120DegreeButton.SetActive(true);
		theta150DegreeButton.SetActive(true);

		phi0DegreeButton.SetActive(true);
		phi60DegreeButton.SetActive(true);
		phi120DegreeButton.SetActive(true);
		phi180DegreeButton.SetActive(true);
		phi240DegreeButton.SetActive(true);
		phi300DegreeButton.SetActive(true);
		phi360DegreeButton.SetActive(true);

		thetaSlider.interactable = true;

		phiSlider.interactable = true;
		phiSlider.wholeNumbers = true;

		densityMatrix.SetActive(true);
		this.setTransparencyOfQuantumProbabilityLabels(quantumBit);
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

		qubitLabel.text = String.Empty;

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
		if(isQuantumBitSelected)
        	this.quantumBit.thetaAngle = sended_theta_angle;
		else{
			if(sended_theta_angle==0)
				this.classicalBit.setOne();
			else
				this.classicalBit.setZero();
		}
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
		if(isQuantumBitSelected){
			int zeroValue = Convert.ToInt32(Math.Round(quantumBit[0] * 10000));
			int measurementValue = Convert.ToInt32(Random.Range(1, 10000));

			quantumBit.phiAngle = 0;

			if(measurementValue >= zeroValue){
				quantumBit.thetaAngle = 180;
			}		
			else{
				quantumBit.thetaAngle = 0;
			}
		}
		else
			classicalBit.NotGate();

		
		setPointers();
	}

	public void switchBit(){
		disableListenersForSliders();
		if(isQuantumBitSelected)
		{
			isQuantumBitSelected = false;
			disableQuantumBit();
			enableClassicalBit();
			Debug.Log("Classical bit is selected");
		}
		else
		{
			isQuantumBitSelected = true;
			disableClassicalBit();
			enableQuantumBit();
			Debug.Log("Quantum bit is selected");
		}
		setPointers();
		setListenersForSliders();
	}

	private void setTransparencyOfQuantumProbabilityLabels(Qubit quantumBit)
	{
		byte zeroTransparency =  Convert.ToByte(80 + Math.Round(quantumBit[0]*120));
		byte oneTransparency = Convert.ToByte(80 + Math.Round(quantumBit[1]*120));

		propabilityZero.color = new Color32(255,255,255,zeroTransparency);
		propabilityOne.color = new Color32(255,255,255,oneTransparency);
	}

	private void setTransparencyOfClassicalProbability(){
		propabilityZero.color = new Color32(255,255,255,255);
		propabilityOne.color = new Color32(255,255,255,255);
	}
}
