using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Cuentas_Corrientes
{
    public class Controlador
    {
        Capa_Modelo_Cuentas_Corrientes.Sentencias sentencias = new Capa_Modelo_Cuentas_Corrientes.Sentencias();
        
        //transacciones
        public DataTable MostrarTransacciones()
        {
            OdbcDataAdapter data = sentencias.DisplayTransacciones();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextId()
        {
            int nextId = sentencias.getMaxIdTransaccion();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public DataTable MostrarProveedor()
        {
            throw new NotImplementedException();
        }

        public string getNextIdProv()
        {
            throw new NotImplementedException();
        }

        public List<string> listadoDeuda()
        {
            List<string> deudasCodes = sentencias.getDeudas();
            return deudasCodes;
        }

        public List<string> listadoPagos()
        {
            List<string> pagosCodes = sentencias.getPagos();
            return pagosCodes;
        }

        public List<string> listadoClientes()
        {
            List<string> clientesCodes = sentencias.getClientes();
            return clientesCodes;
        }

       

        public List<string> listadoPais()
        {
            List<string> paisCodes = sentencias.getPais();
            return paisCodes;
        }

        public DataTable queryProveedor(TextBox txt_nombre)
        {
            throw new NotImplementedException();
        }

        public int guardarTransaccion(TextBox PK_id_transaccion, string sFk_id_clientes, string sFk_id_pais, string sfecha_transaccion,
            string scuenta_transaccion, string scuotas_transaccion, string sFk_id_deuda, string smonto_deuda, string smonto_transaccion,
            string ssaldo_pendiente, string sFk_id_pago, string stipo_moneda, string sserie_transaccion, string sestado_transaccion)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(PK_id_transaccion.Text) || string.IsNullOrEmpty(sFk_id_clientes) || string.IsNullOrEmpty(sFk_id_pais) ||
                string.IsNullOrEmpty(sfecha_transaccion) || string.IsNullOrEmpty(scuenta_transaccion) || string.IsNullOrEmpty(scuotas_transaccion)||
                string.IsNullOrEmpty(sFk_id_deuda) || string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(smonto_transaccion)||
                string.IsNullOrEmpty(ssaldo_pendiente) || string.IsNullOrEmpty(sFk_id_pago) || string.IsNullOrEmpty(stipo_moneda)||
                string.IsNullOrEmpty(sserie_transaccion) || string.IsNullOrEmpty(sestado_transaccion))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarTransaccion(PK_id_transaccion.Text, sFk_id_clientes, sFk_id_pais, sfecha_transaccion,
            scuenta_transaccion, scuotas_transaccion, sFk_id_deuda, smonto_deuda, smonto_transaccion,
            ssaldo_pendiente, sFk_id_pago, stipo_moneda, sserie_transaccion, sestado_transaccion);
                return 1;
            }
        }

        public void borrarProveedor(TextBox txt_id_proveedor)
        {
            throw new NotImplementedException();
        }

        // Paises
        public DataTable MostrarPaises()
        {
            OdbcDataAdapter data = sentencias.DisplayPaises();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextIdP()
        {
            int nextId = sentencias.getMaxIdPaises();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        public int guardarPaises(TextBox Pk_id_pais, string snombre_pais, string sregion_pais, string sestatus_pais)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_pais.Text) || string.IsNullOrEmpty(snombre_pais) || string.IsNullOrEmpty(sregion_pais) ||string.IsNullOrEmpty(sestatus_pais))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarPais(Pk_id_pais.Text, snombre_pais, sregion_pais, sestatus_pais);
                return 1;
            }
        }

        public DataTable queryPaises(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryPaises(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarPais(TextBox Pk_id_pais)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_pais.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el pais #" + Pk_id_pais.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarPais(Pk_id_pais.Text);
                    return 1;
                }
            }
        }

        // Vendedor

        public DataTable MostrarVendedores()
        {
            OdbcDataAdapter data = sentencias.DisplayVendedores();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextIdV()
        {
            int nextId = sentencias.getMaxIdVendedor();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        public int guardarVendedor(TextBox Pk_id_vendedor, string snombre_vendedor, string sdireccion_vendedor, string stelefono_vendedor, 
            string sdepartamento_vendedor, string sestado_vendedor)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_vendedor.Text) || string.IsNullOrEmpty(snombre_vendedor) || string.IsNullOrEmpty(sdireccion_vendedor) 
                || string.IsNullOrEmpty(stelefono_vendedor) || string.IsNullOrEmpty(sdepartamento_vendedor) || string.IsNullOrEmpty(sestado_vendedor))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarVendedor(Pk_id_vendedor.Text, snombre_vendedor, sdireccion_vendedor, stelefono_vendedor, sdepartamento_vendedor, sestado_vendedor);
                return 1;
            }
        }

        public DataTable queryVendedor(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryVendedor(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarVendedor(TextBox Pk_id_vendedor)
        {
            
            if (string.IsNullOrEmpty(Pk_id_vendedor.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                
                DialogResult result = MessageBox.Show("¿Desea eliminar el vendedor #" + Pk_id_vendedor.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarVendedor(Pk_id_vendedor.Text);
                    return 1;
                }
            }
        }

        //DEUDAS
        public DataTable MostrarDeudas()
        {
            OdbcDataAdapter data = sentencias.DisplayDeudas();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public String getNextIdD()
        {
            int nextId = sentencias.getMaxIdDeudas();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        public List<string> listadoPagosd()
        {
            List<string> pagosCodes = sentencias.getPagosd();
            return pagosCodes;
        }

        public List<string> listadoClientesd()
        {
            List<string> clientesCodes = sentencias.getClientesd();
            return clientesCodes;
        }

        public List<string> listadoCobradord()
        {
            List<string> cobradorCodes = sentencias.getCobrador();
            return cobradorCodes;
        }

        public int guardarDeudas(TextBox Pk_id_deuda, string sFk_id_cliente, string sFk_id_cobrador, string sFk_id_pago, 
            string smonto_deuda, string sfecha_inicio_deuda, string sfecha_vencimiento_deuda, string sdescripcion_deuda, string sestado_deuda)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_deuda.Text) || string.IsNullOrEmpty(sFk_id_cliente) || string.IsNullOrEmpty(sFk_id_cobrador)
                || string.IsNullOrEmpty(sFk_id_pago) || string.IsNullOrEmpty(smonto_deuda) || string.IsNullOrEmpty(sfecha_inicio_deuda) 
                || string.IsNullOrEmpty(sfecha_vencimiento_deuda) || string.IsNullOrEmpty(sdescripcion_deuda) || string.IsNullOrEmpty(sestado_deuda))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarDeuda(Pk_id_deuda.Text, sFk_id_cliente, sFk_id_cobrador, sFk_id_pago, smonto_deuda, 
                    sfecha_inicio_deuda, sfecha_vencimiento_deuda, sdescripcion_deuda, sestado_deuda);
                return 1;
            }
        }

        public DataTable queryDeuda(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryDeuda(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }
        public int borrarDeuda(TextBox Pk_id_deuda)
        {

            if (string.IsNullOrEmpty(Pk_id_deuda.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {

                DialogResult result = MessageBox.Show("¿Desea eliminar la deuda #" + Pk_id_deuda.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarDeuda(Pk_id_deuda.Text);
                    return 1;
                }
            }
        }

        //Clientes
        public String getNextIdC()
        {
            int nextId = sentencias.getMaxIdClientes();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public List<string> listadoVendedor()
        {
            List<string> vendedorCodes = sentencias.getVendedores();
            return vendedorCodes;
        }

        public DataTable MostrarClientes()
        {
            OdbcDataAdapter data = sentencias.DisplayClientes();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public int guardarClientes(TextBox Pk_id_cliente, string sFk_id_vendedor, string snombre_cliente, string sdireccion_cliente, string stelefono_cliente, string ssaldo_cuenta, string sestado_cliente)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_cliente.Text) || string.IsNullOrEmpty(sFk_id_vendedor) || string.IsNullOrEmpty(snombre_cliente) || string.IsNullOrEmpty(sdireccion_cliente)
                || string.IsNullOrEmpty(stelefono_cliente) || string.IsNullOrEmpty(ssaldo_cuenta) || string.IsNullOrEmpty(sestado_cliente))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarClientes(Pk_id_cliente.Text, sFk_id_vendedor, snombre_cliente, sdireccion_cliente, stelefono_cliente, ssaldo_cuenta, sestado_cliente);
                return 1;
            }
        }
        public DataTable queryCliente(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryCliente(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarCliente(TextBox Pk_id_cliente)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_cliente.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar al cliente #" + Pk_id_cliente.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarCliente(Pk_id_cliente.Text);
                    return 1;
                }
            }
        }

        //Cobrador

        public DataTable MostrarCobrador()
        {
            OdbcDataAdapter data = sentencias.DisplayCobradores();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public int guardarCobrador(TextBox idCobrador, string sNombre, string sDireccion, TextBox sTelefono, string sDepartamento, string sEstado)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idCobrador.Text) || string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sDireccion) ||
                string.IsNullOrEmpty(sTelefono.Text) || string.IsNullOrEmpty(sDepartamento) || string.IsNullOrEmpty(sEstado))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarCobrador(idCobrador.Text, sNombre, sDireccion, sTelefono.Text, sDepartamento, sEstado);
                return 1;
            }
        }

        public DataTable queryCobrador(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryCobrador(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }
        public String getNextIdCo()
        {
            int nextId = sentencias.getMaxIdCobrador();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public int borrarCobrador(TextBox Pk_id_cobrador)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_cobrador.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el cobrador #" + Pk_id_cobrador.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarcobrador(Pk_id_cobrador.Text);
                    return 1;
                }
            }
        }

        //Forma de pago
        public int guardarFormaPago(TextBox idFormaPago, string sNombreFrmPago, string sMoneda, string sEstadoFrmPago)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idFormaPago.Text) || string.IsNullOrEmpty(sNombreFrmPago) || string.IsNullOrEmpty(sMoneda) ||
                string.IsNullOrEmpty(sEstadoFrmPago))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarFrmpago(idFormaPago.Text, sNombreFrmPago, sMoneda, sEstadoFrmPago);
                return 1;
            }
        }

        public String getNextIdF()
        {
            int nextId = sentencias.getMaxIdFrmPago();
            nextId = nextId + 1;
            return nextId.ToString();
        }

        public DataTable MostrarFrmPago()
        {
            OdbcDataAdapter data = sentencias.DisplayFrmPago();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public DataTable queryFrmPago(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryFrmPago(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarFrmPago(TextBox Pk_id_pago)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_pago.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar el cobrador #" + Pk_id_pago.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarFrmPago(Pk_id_pago.Text);
                    return 1;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////
        ///PROVEEDORES
        ///
        // Proveedores

        public String getNextIdPr()
        {
            int nextId = sentencias.getMaxIdPr();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        public int guardarProve(TextBox Pk_id_proveedor, string sfecha_registro, string snombre_proveedor, string sdireccion, string stelefono, string semail, string ssaldo_cuenta, string sestado_proveedor)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_proveedor.Text) || string.IsNullOrEmpty(sfecha_registro) || string.IsNullOrEmpty(snombre_proveedor) ||
                string.IsNullOrEmpty(sdireccion) || string.IsNullOrEmpty(stelefono) || string.IsNullOrEmpty(semail)
                || string.IsNullOrEmpty(ssaldo_cuenta) || string.IsNullOrEmpty(sestado_proveedor))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarProveedor(Pk_id_proveedor.Text, sfecha_registro, snombre_proveedor,
            sdireccion, stelefono, semail, ssaldo_cuenta, sestado_proveedor);
                return 1;
            }
        }

        public DataTable MostrarProv()
        {
            OdbcDataAdapter data = sentencias.DisplayProv();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable queryProv(TextBox query)
        {
            OdbcDataAdapter data2 = sentencias.queryProv(query.Text);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            return tabla2;
        }

        public int borrarProv(TextBox Pk_id_proveedor)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(Pk_id_proveedor.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                //luego rectificamos que el usuario quiere borrar el reporte
                DialogResult result = MessageBox.Show("¿Desea eliminar al proveedor #" + Pk_id_proveedor.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    sentencias.eliminarProv(Pk_id_proveedor.Text);
                    return 1;
                }
            }
        }
    }
   
}
