using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject AICar1;
    public GameObject AICar2;
    public GameObject AICar3;

    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        AICar1.GetComponent<CarController>().enabled = true;
        AICar2.GetComponent<CarController>().enabled = true;
        AICar3.GetComponent<CarController>().enabled = true;
    }
}
