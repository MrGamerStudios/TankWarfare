using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankSelection : MonoBehaviour {

    public Button HealthTButton;
    public Button DamageTButton;
    public GameObject HealthTankObj;
    public GameObject DamageTankObj;
    public GameManager Manager; //Game Manager
    public GameObject m_TankHealth;
    public GameObject m_TankDamage;

    void Awake () {
        Manager = GameObject.Find ("GameManager").GetComponent <GameManager>(); 

    }


	// Use this for initialization
	void Start () {

  
        	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void extraHealthSelected()
    {

    }

    public void extradamangeSelected()
    {

    }

}
    

