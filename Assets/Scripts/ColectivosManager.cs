using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectivosManager : MonoBehaviour
{

    [SerializeField] ColectivoScript[] colectivos;
    [SerializeField] float maxCapacidad = 60;

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void CargarNaftaRandomATodosLosColectivos()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ActivarTodosLosColectivos();
            AsignarCapacidadRandomALosColectivos();
            CargarNaftaRandomATodosLosColectivos();
            DesactivarTodosLosColectivos();
            ActivarColectivosConMenosDeMedioTanque();
            ActivarSignoDeAdvertenciaEnColectivosConMenosDe10DeCombustible();
            MostrarPromedioDeCombustible();
            MostrarCombustibleFaltanteParaLlenarTodosLosTanques();
        }
    }

    private void AsignarCapacidadRandomALosColectivos()
    {

    }


    private void ActivarColectivosConMenosDeMedioTanque()
    {

    }

    private void DesactivarTodosLosColectivos()
    {

    }


    private void ActivarTodosLosColectivos()
    {

    }

    private void ActivarSignoDeAdvertenciaEnColectivosConMenosDe10DeCombustible()
    {

    }

    private void MostrarPromedioDeCombustible()
    {

    }

    private void MostrarCombustibleFaltanteParaLlenarTodosLosTanques()
    {

    }
}
