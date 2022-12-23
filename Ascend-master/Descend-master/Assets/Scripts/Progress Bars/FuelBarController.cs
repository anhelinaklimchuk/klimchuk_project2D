﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBarController : BarController
{
    public override void Awake()
	{
		base.Awake();
		base.ValueChanged += FuelChanged;

	}

	void FuelChanged(float newHealth)
	{
		//TO-DO: apply animation
	}
    
    public static FuelBarController FuelBarControllerWithName(string name)
    {
        return GameObject.Find(name).GetComponent<FuelBarController>();
    }
}