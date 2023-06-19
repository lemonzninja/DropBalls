using System;
using _Scripts.Button;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private SpawnObjectsButton _spawnObjectsButton;
    
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private Transform spawnPoint;

    private float _timer = 0f;
    
    private void Start()
    {
        _spawnObjectsButton = FindObjectOfType<SpawnObjectsButton>();
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        
        if (_spawnObjectsButton.canSpawn & _timer <= 0)
        {
            SpawnObjects();            
            _spawnObjectsButton.canSpawn = false;
            _timer = 1f;
        }
    }
    
    
    private void SpawnObjects()
    {
        // pick a random object from the array
        var randomIndex = UnityEngine.Random.Range(0, objectsToSpawn.Length);
        // spawn the object at the spawn point
        Instantiate(objectsToSpawn[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}
