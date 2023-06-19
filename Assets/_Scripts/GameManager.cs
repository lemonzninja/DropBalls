using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private SpawneObjectsButton _spawneObjectsButton;
    
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private Transform spawnPoint;

    private float timer = 0f;
    
    private void Start()
    {
        _spawneObjectsButton = FindObjectOfType<SpawneObjectsButton>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        
        if (_spawneObjectsButton.CanSpawn & timer <= 0)
        {
            SpawnObjects();            
            _spawneObjectsButton.CanSpawn = false;
            timer = 1f;
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
