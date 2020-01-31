using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drink : MonoBehaviour
{
	String name;
	int[] recipe;

	public drink(String name, int[] recipe){
		this.name = name;
		this.recipe = recipe;
	}

	public String getName(){
		return name;
	}

	public int[] getRecipe(){
		return recipe;
	}
}