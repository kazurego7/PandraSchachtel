﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPlace : MonoBehaviour {

	[SerializeField] Transform place;
	GameObject frame;
	public bool FrameActivity {
		get;
		private set;
	}

	void Start () {
		frame = transform.GetChild (0).gameObject;
		SetFrameActive (frame.activeInHierarchy);
	}
	public string PlacedCardName {
		get { return place.GetChild (0).name; }
	}

	public void SetFrameActive (bool flag) {
		FrameActivity = flag;
	}
	public void DrawFrame () {
		frame.SetActive (FrameActivity);
	}
}