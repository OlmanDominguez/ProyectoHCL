﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoHCL
{
    public  class BaseDatosHCL
    {

            public static MySqlConnection ObtenerConexion()
            {

                MySqlConnection conectar = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");

                conectar.Open();

                return conectar;
            }
     }
 }

