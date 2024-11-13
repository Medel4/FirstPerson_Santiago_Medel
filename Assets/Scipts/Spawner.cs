using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] puntosSpawn;
    [SerializeField] Enemigo enemigoPrefab;

    // Start is called before the first frame update
    void Start()
    {
      Instantiate(enemigoPrefab, puntosSpawn[0].position, Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
