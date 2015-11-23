﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
