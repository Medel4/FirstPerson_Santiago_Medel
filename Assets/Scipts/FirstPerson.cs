using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] 
    CharacterController cc;
    void Start()
    {

        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
            
    }

    
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 input = new Vector2(h, v).normalized;

        if (input.magnitude > 0)
        {
            float anguloRotacion = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
            transform.eulerAngles = new Vector3(0, anguloRotacion, 0);

            Vector3 movimiento = Quaternion.Euler(0, anguloRotacion, 0) * Vector3.forward;
            cc.Move( movimiento * velocidadMovimiento * Time.deltaTime);
        }
        
        
        
    }
}
