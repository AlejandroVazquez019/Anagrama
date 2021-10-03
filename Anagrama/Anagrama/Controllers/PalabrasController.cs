using Microsoft.AspNetCore.Mvc;
using Anagrama.Entities;
using System;
using System.Linq;
/*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1: IMC Masa Muscular
    Nombre del alumno: Jose Alejandro Vazquez Suaste
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace Anagrama.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class PalabrasController : ControllerBase

    {
        [HttpPost]
        public string Post (Palabra palabra)

        {
            string esana = "Si es un anagrama";
            string noesana = "No es un anagrama";

            string N1 = String.Concat(palabra.P1.OrderBy(c=>c));
            string N2 = String.Concat(palabra.P1.OrderBy(c=>c));
        
            if (N1 == N2)

            {
                return esana;
            }
            else
            {
                return noesana;
            }
        }
    }
}