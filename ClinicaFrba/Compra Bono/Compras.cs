﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Compra_Bono
{
    class Compras
    {

        public static void comprarConNroDeAfiliado(string nroAfiliado, int cantidad, Double monto)
        {
            String dni = nroAfiliado.Substring(0, 8);
            comprar(int.Parse(dni), cantidad, monto);
        }

        public static void comprar(int documento, int cantidad, Double monto)
        {
            SqlConnection connection = util.Sql.connect("gd");

            String insertCompra = "INSERT INTO Compras(fecha, cantidad, monto, afiliado_usuario_dni) VALUES(GETDATE(), {0}, {1}, {2})";
            insertCompra = String.Format(insertCompra, cantidad, monto, documento);

            SqlCommand command = new SqlCommand(insertCompra, connection);
            command.ExecuteNonQuery();

            String compraIdQuery = "select top 1 compra_id from Compras where afiliado_usuario_dni = {0} order by fecha desc";
            compraIdQuery = String.Format(compraIdQuery, documento);
            DataTable compraIdResult = util.Sql.query(compraIdQuery);
            String compraID = compraIdResult.Rows[0][0].ToString();

            for (int i = 0; i < cantidad; i++)
            {
                String insertBono = "insert into Bonos(afiliado_dni, compra_id, nro_bono, plan_codigo) VALUES({0}, {1}, ({2}), (select plan_medico_codigo from Afiliados where afiliado_dni = {3}))";
                insertBono = String.Format(insertBono, documento, compraID, "select top 1 nro_bono + 1 from Bonos order by nro_bono desc", documento);
                command = new SqlCommand(insertBono, connection);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }


        internal static Double calcularMonto(int cantidad, int dni)
        {
            SqlConnection connection = util.Sql.connect("gd");

            String queryPrecio = "select precio_bono_consulta from Planes_Medicos where codigo = (select plan_medico_codigo from Afiliados where afiliado_dni = {0})";
            queryPrecio = String.Format(queryPrecio, dni);
            DataTable precioData = util.Sql.query(queryPrecio);
            Double precio = Double.Parse(precioData.Rows[0][0].ToString());
            return precio * cantidad;
        }

        internal static Double calcularMontoPorNroDeAfiliado(int cantidad, string nroAfiliado)
        {
            String dni = nroAfiliado.Substring(0, 8);
            return calcularMonto(cantidad, int.Parse(dni));
        }
    }
}