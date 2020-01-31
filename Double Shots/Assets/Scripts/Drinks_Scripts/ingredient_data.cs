using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredient : MonoBehaviour
{
	String name;
	int index;

	public ingredient (String name, int index){
		this.name = name;
		this.index = index;
	}

	public String getName(){
		return name;
	}

	public int getIndex(){
		return index;
	}
}