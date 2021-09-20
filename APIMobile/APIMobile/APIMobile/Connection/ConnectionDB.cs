﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace APIMobile.Connection
{
    public class ConnectionDB
    {

       
            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            public static string msg;

            public MySqlConnection ConectarBD()
            {
                try
                {
                    connect.Open();
                }
                catch (Exception error)
                {
                    msg = "Erro ao conectar o Banco de Dados" + error.Message;
                }
                return connect;
            }

            public MySqlConnection DesconectarBD()
            {
                try
                {
                    connect.Close();
                }
                catch (Exception error)
                {
                    msg = "Não foi possível desconectar o Banco de Dados" + error.Message;
                }
                return connect;
            }
        

    }
}