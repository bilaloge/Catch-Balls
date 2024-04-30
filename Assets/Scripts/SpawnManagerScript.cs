using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] animalPrefaps;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S)) s ye basýnca iþlemi yapma kodu
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefaps.Length);
        Vector3 spawnPos = new Vector3(Random.Range(20, -20), 0, 20);
        Instantiate(animalPrefaps[animalIndex], spawnPos, animalPrefaps[animalIndex].transform.rotation);
    }
}
