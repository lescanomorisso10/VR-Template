﻿using UnityEngine;
using System.Collections;

public class CarSwitch : MonoBehaviour
{

    public Transform[] Cars;
    public Transform MyCamera;


    public void CurrentCarActive(int current)
    {

        int amount = 0;

        foreach (Transform Car in Cars)
        {
            if (current == amount)
            {
                MyCamera.GetComponent<VehicleCamera>().target = Car;

                Car.GetComponent<VehicleControl>().activeControl = true;
            }
            else
            {
                Car.GetComponent<VehicleControl>().activeControl = false;
            }

            amount++;
        }
    }




}
