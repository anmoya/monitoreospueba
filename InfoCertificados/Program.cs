using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCertificados
{
    class Program
    {
        string prod = String.Empty;
        static void Main(string[] args)
        {
            //TODO
            /* Valido config
             * Conecto a base de datos
             * Busco certificados por holding.
             *      --> Consulto cuantos holdings existen
             *      --> Si existe uno solo, busco los certificados
             *      --> Si existen varios, hago un arreglo con cada uno
             * Busco certificados del Holding
             * Obtengo el pem en base64, lo convierto y lo guardo en estructura
             * Consulto fecha de caducidad
             * Comparo con tiempo configurado
             *      --> Si es mayor, genero correo a cliente.
             *      --> Si es menor, paso al siguiente
             * Si no existen mas certificados por validar, cierro la instancia.b  
             */
        }
    }
}
