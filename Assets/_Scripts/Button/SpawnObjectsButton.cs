using UnityEngine;

namespace _Scripts.Button
{
	public class SpawnObjectsButton : MonoBehaviour
	{
		public bool canSpawn = false;
	
		private UnityEngine.UI.Button _button;
	
		private void Start()
		{
			_button = GetComponent<UnityEngine.UI.Button>();
			_button.onClick.AddListener(CanSpawnObjects);
		}

		private void CanSpawnObjects()
		{
			canSpawn = true;
		}
	}
}
