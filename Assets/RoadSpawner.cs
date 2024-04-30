using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadSectionPrefab;
    private bool enteredSpawnTrigger = false;
    private Vector3 nextSpawnPoint = new Vector3(0, 0, 120);

    private GameObject previousRoadSection;
    private GameObject startRoad;

    private void Start()
    {
        startRoad = Instantiate(roadSectionPrefab, new Vector3(0, 0 ,0), Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!enteredSpawnTrigger && other.gameObject.CompareTag("Trigger"))
        {
            enteredSpawnTrigger = true;
            SpawnRoadSection();
            previousRoadSection = other.transform.parent.gameObject;
        }
    }

    private void SpawnRoadSection()
    {
        if (previousRoadSection != null)
        {
            Destroy(previousRoadSection);
        }
        else
        {
            previousRoadSection = startRoad;
        }

        GameObject newRoadSection = Instantiate(roadSectionPrefab, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint += new Vector3(0, 0, 120);
    }

    private void OnTriggerExit(Collider other)
    {
       if (other.gameObject.CompareTag("Trigger"))
        {
            enteredSpawnTrigger = false;
        }
    }
}
