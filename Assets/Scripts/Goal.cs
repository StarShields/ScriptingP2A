using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public LEVEL01CONTROLLER score;
    PlayerBase player;
    public AudioSource goal;
    //[SerializeField] Rigidbody Hazard;
    //[SerializeField] Transform spawnLocations;
    
    [SerializeField] GameObject[] _spawnObjects = null;
    [SerializeField] Transform[] _spawnLocations = null;
    // public AudioSource goal;
    public ParticleSystem GoalEffect;
    public void OnTriggerEnter(Collider other)
    {

        PlayerBase player
          = other.gameObject.GetComponent<PlayerBase>();
        if (player != null)
        {
            SpawnNewEnemies();
           score.IncreaseScore(1);
            goal.Play();
            GoalEffect.Play();
        }

    }

    void SpawnNewEnemies()
    {
        // calculate randomization
        int randomObjectNumber = Random.Range(0, _spawnObjects.Length);
        int randomLocationNumber = Random.Range(0, _spawnLocations.Length);
        // calculate random spawn transform, for readability
        Transform spawnLocation = _spawnLocations[randomLocationNumber];

        // spawn gameObject
        GameObject spawnedObject = Instantiate(_spawnObjects[randomObjectNumber],
            spawnLocation.position, spawnLocation.rotation);


        //PlaySpawnFeedback(spawnLocation);
    }
}
