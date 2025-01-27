﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetearVehiculos();
            vehiculos[Random.Range(0, vehiculos.Length - 1)].SetActive(true);
            //Se desactiven todos los vehiculos
            //Y se active un vehivulo al azar del array
        }
    }

    void ResetearVehiculos()
    {
        //desactivar todos los elementos del array
        DesactivarTodosLosElementos();
        //activar solo el primer elemento
        vehiculos[0].SetActive(true);
    }
    void DesactivarTodosLosElementos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}