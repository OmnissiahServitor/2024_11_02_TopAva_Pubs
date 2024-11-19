using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmAuthors : Form
    {
        DataSet ds;

        public frmAuthors()
        {
            InitializeComponent();
            actualizarTabla();
            this.CenterToScreen();

            Datos dt = new Datos();

            // Codigo para agregar los nombres de las columnas de las tablas para que el usuario busque de acuerdo a su seleccion
            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'authors'");

            cmbAuthorSearchBy.DataSource = ds.Tables[0];
            cmbAuthorSearchBy.DisplayMember = "COLUMN_NAME";
            cmbAuthorSearchBy.ValueMember = "ORDINAL_POSITION";
        }

        private void btnAuthorModificar_Click(object sender, EventArgs e)
        {
            string id = mskAuthorID.Text; // otro cambio

            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE authors SET " +
                    "au_lname = '" + txtLastName.Text + "', " +
                    "au_fname = '" + txtFirstName.Text + "', " +
                    "phone = '" + mskPhone.Text + "', " +
                    "address = '" + txtAddress.Text + "', " +
                    "city = '" + txtCity.Text + "', " +
                    "state = '" + mskState.Text + "', " +
                    "zip = '" + mskZip.Text + "', " +
                    "contract = '" + chkAuthorContract.Checked +
                    "' WHERE au_id = '" + id + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnModificarAuthors

        private void btnAuthorGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string contrato;

                if (chkAuthorContract.Checked)
                    contrato = "1";
                else
                    contrato = "0";

                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO Authors( au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                    "VALUES ('" + mskAuthorID.Text + "','" + txtLastName.Text + "','" + txtFirstName.Text + "','" + mskPhone.Text + "','" +
                    txtAddress.Text + "','" + txtCity.Text + "','" + mskState.Text + "','" + mskZip.Text + "','" + contrato + "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // end btnAuthorGuardar_Click()

        private void btnAuthorLimpiar_Click(object sender, EventArgs e)
        {
            mskAuthorID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            mskPhone.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            mskState.Text = "";
            mskZip.Text = "";
            chkAuthorContract.Checked = false;
        } // end btnAuthorLimpiar()

        private void btnAuthorEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskAuthorID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM authors WHERE au_id = '" + mskAuthorID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskAuthorID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnAuthorEliminar

        private void btnAuthorBuscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM authors WHERE " + cmbAuthorSearchBy.Text + " = '" + txtAuthorBuscar.Text + "'");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        } // endAuthorBuscar

        private void btnResetearAuthors_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        } // endAuthorResetear

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT au_id AS 'ID', au_lname AS 'Last name', au_fname AS 'First name', phone AS 'Phone', address AS 'Address', city AS 'City', state AS 'State', zip AS 'Zip', contract AS 'Contract'" +
                " FROM authors ");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

    } // end frmAuthors
} // end namespace
