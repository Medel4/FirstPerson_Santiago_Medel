using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInteracciones : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float distanciaInteraccion;
    Transform interactuableActual;
    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, distanciaInteraccion))
        {

            if (hit.transform.TryGetComponent(out CajaMunicion ScriptCaja))
            {

                interactuableActual = hit.transform;
                interactuableActual.GetComponent<Outline>().enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {

                    ScriptCaja.AbrirCaja();

                }

            }

        }
        else 
        {

            interactuableActual.GetComponent<Outline>().enabled = false;
            interactuableActual = null;

        }
    }
}
