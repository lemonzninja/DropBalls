using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawneObjectsButton : MonoBehaviour
{
	public bool CanSpawn = false;
	
	private Button _button;
	
	private void Start()
	{
		_button = GetComponent<Button>();
		_button.onClick.AddListener(CanSpawnObjects);
	}

	private void CanSpawnObjects()
	{
		CanSpawn = true;
	}
}
