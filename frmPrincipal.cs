using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmPrincipal : Form
    {

        // Atributos
        DataSet ds;

        public frmPrincipal()
        {

            InitializeComponent();
            this.CenterToScreen();
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            // MessageBox.Show("Ancho = " + this.Size.Width.ToString() + "\nAltura = " + this.Size.Height);
        } // end constructor default

        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            labUsuario.Text = "Usuario: " + usuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT au_id AS 'ID', au_lname AS 'Last name', au_fname AS 'First name', phone AS 'Phone', address AS 'Address', city AS 'City', state AS 'State', zip AS 'Zip', contract AS 'Contract'" +
                " FROM authors ");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT* FROM publishers");
                dgvPublishers.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM titles");
                dgvTitles.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM titleauthor");
                dgvTitleAuthor.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM stores");
                dgvStores.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM sales");
                dgvSales.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM roysched");
                dgvRoysched.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM discounts");
                dgvDiscounts.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM jobs ");
                dgvJobs.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM pub_info");
                dgvPubInfo.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM employee");
                dgvEmployee.DataSource = ds.Tables[0];

            } // end if ds != null

            // Codigo para agregar los nombres de las columnas de las tablas para que el usuario busque de acuerdo a su seleccion
            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'authors'");

            cmbAuthorSearchBy.DataSource = ds.Tables[0];
            cmbAuthorSearchBy.DisplayMember = "COLUMN_NAME";
            cmbAuthorSearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'publishers'");
            cmbPublishers_SearchBy.DataSource = ds.Tables[0];
            cmbPublishers_SearchBy.DisplayMember = "COLUMN_NAME";
            cmbPublishers_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'titles'");
            cmbTitles_SearchBy.DataSource = ds.Tables[0];
            cmbTitles_SearchBy.DisplayMember = "COLUMN_NAME";
            cmbTitles_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT pub_id FROM publishers");
            cmbTitles_publisherID.DataSource = ds.Tables[0];
            cmbTitles_publisherID.DisplayMember = "pub_id";

        } // end frmPrincipal_Load() 

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
                    actualizarTabla("authors");
                }
                else
                {
                    MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtNombre.Clear();
                    //txtPaterno.Clear();
                    //txtMaterno.Clear();
                    //txtCurp.Clear();
                    //cmbSexo.Text = "";
                }
            }
        } // end btnAuthorGuardar_Click()

        public void actualizarTabla(string nombreTabla)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM " + nombreTabla);

            if (ds != null)
            {
                switch (nombreTabla)
                {
                    case "authors":     //1
                        ds = dt.consulta("SELECT au_id AS 'ID', au_lname AS 'Last name', au_fname AS 'First name', phone AS 'Phone', address AS 'Address', city AS 'City', state AS 'State', zip AS 'Zip', contract AS 'Contract'" +
                " FROM authors ");
                        dgvAuthors.DataSource = ds.Tables[0];
                        break;
                    case "publishers":  //2
                        dgvPublishers.DataSource = ds.Tables[0];
                        break;
                    case "titles":      //3
                        dgvTitles.DataSource = ds.Tables[0];
                        break;
                    case "titleauthor": //4
                        dgvTitles.DataSource = ds.Tables[0];
                        break;
                    case "stores":      //5
                        dgvStores.DataSource = ds.Tables[0];
                        break;
                    case "sales":       //6
                        dgvSales.DataSource = ds.Tables[0];
                        break;
                    case "roysched":    //7
                        dgvRoysched.DataSource = ds.Tables[0];
                        break;
                    case "discounts":   //8
                        dgvDiscounts.DataSource = ds.Tables[0];
                        break;
                    case "jobs":        //9
                        dgvJobs.DataSource = ds.Tables[0];
                        break;
                    case "pub_info":    //10
                        dgvPubInfo.DataSource = ds.Tables[0];
                        break;
                    case "employee":    //11
                        dgvEmployee.DataSource = ds.Tables[0];
                        break;

                    default:            // ninguno de los nombres insertados es valido
                        MessageBox.Show("Nombre de tabla \"" + nombreTabla + "\" no valido", "Error Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                } // end swith nombreTabla
            } // end if ds!=null
        } // end actualizarTabla()

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
        } // end btnAuthorLimpiar_Click()

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
                        actualizarTabla("authors");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //txtNombre.Clear();
                        //txtPaterno.Clear();
                        //txtMaterno.Clear();
                        //txtCurp.Clear();
                        //cmbSexo.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnAuthorEliminar_Click()

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvAuthors.Rows[e.RowIndex];

            // MessageBox.Show("Valor = " + filaSeleccionada.Cells[0].Value.ToString(),"Sistema");
            mskAuthorID.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtLastName.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtFirstName.Text = filaSeleccionada.Cells[2].Value.ToString();
            mskPhone.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtAddress.Text = filaSeleccionada.Cells[4].Value.ToString();
            txtCity.Text = filaSeleccionada.Cells[5].Value.ToString();
            mskState.Text = filaSeleccionada.Cells[6].Value.ToString();
            mskZip.Text = filaSeleccionada.Cells[7].Value.ToString();
            chkAuthorContract.Checked = bool.Parse(filaSeleccionada.Cells[8].Value.ToString());
            // MessageBox.Show("Valor = " + filaSeleccionada.Cells[8].Value.ToString(), "Sistema");
        } // end dgvAuthors_CellContentClick()

        private void btnAuthorBuscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM authors WHERE " + cmbAuthorSearchBy.Text + " = '" + txtAuthorBuscar.Text + "'");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        } // end btnAuthorBuscar_Click()

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
                    actualizarTabla("authors");
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
        } // end btnAuthorModificar_Click()

        private void btnResetearAuthors_Click(object sender, EventArgs e)
        {
            actualizarTabla("authors"); // Cambios
        } // end btnResetearAuthors_Click

        private void btnPublishersModificar_Click(object sender, EventArgs e)
        {
            string id = mskPublishers_ID.Text;

            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE publishers SET " +
                    "pub_name = '" + txtPublisher_name.Text + "', " +
                    "city = '" + txtPublisher_City.Text + "', " +
                    "state = '" + mskPublisher_State.Text + "', " +
                    "country = '" + txtPublisher_Country.Text + "', " +
                    "' WHERE pub_id = '" + id + "'");

                if (j)
                {
                    actualizarTabla("publishers");
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Publishers");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnPublishersModificar_Click

        private void btnPublishersGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO publishers( pub_id, pub_name, city, state, country) " +
                    "VALUES ('" + mskPublishers_ID.Text + "','" + txtPublisher_name.Text + "','" + txtPublisher_City.Text + "','" + mskPublisher_State.Text + "','" +
                    txtPublisher_Country.Text + "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema", MessageBoxButtons.OK);
                    actualizarTabla("publishers");
                }
                else
                {
                    MessageBox.Show("Error", "Sistema tabla Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtNombre.Clear();
                    //txtPaterno.Clear();
                    //txtMaterno.Clear();
                    //txtCurp.Clear();
                    //cmbSexo.Text = "";
                }
            }
        } // end btnPublishersGuardar_Click

        private void btnPublishersLimpiar_Click(object sender, EventArgs e)
        {
            mskPublishers_ID.Text = "";
            txtPublisher_name.Text = "";
            txtPublisher_City.Text = "";
            mskPublisher_State.Text = "";
            txtPublisher_Country.Text = "";
        } // end btnPublishersLimpiar_Click

        private void btnPublishersEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskPublishers_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM publishers WHERE pub_id = '" + mskPublishers_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskPublishers_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
                        actualizarTabla("publishers");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //txtNombre.Clear();
                        //txtPaterno.Clear();
                        //txtMaterno.Clear();
                        //txtCurp.Clear();
                        //cmbSexo.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error tabla Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnPublishersEliminar_Click

        private void btnPublishers_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM publishers WHERE " + cmbPublishers_SearchBy.Text + " = '" + txtPublishers_Buscar.Text + "'");

            if (ds != null)
            {
                dgvPublishers.DataSource = ds.Tables[0];
            }
        } // end btnPublishers_Buscar_Click

        private void btnPublishers_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla("publishers");
        } // end btnPublishers_Resetear_Click

        private void dgvPublishers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvPublishers.Rows[e.RowIndex];


            mskPublishers_ID.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtPublisher_name.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtPublisher_City.Text = filaSeleccionada.Cells[2].Value.ToString();
            mskPublisher_State.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtPublisher_Country.Text = filaSeleccionada.Cells[4].Value.ToString();

        }

        private void btnTitles_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE titles SET " +
                    "title = '" + txtTitle_name.Text + "', " +
                    "type = '" + txtTitle_Type.Text + "', " +
                    "pub_id = '" + cmbTitles_publisherID.Text + "', " +
                    "price = '" + txtTitle_Price.Text + "', " +
                    "advance = '" + txtTitle_Advance.Text + "', " +
                    "royalty = '" + txtTitle_Royalty.Text + "', " +
                    "ytd_sales = '" + txtTitle_Sales.Text + "', " +
                    "notes = '" + rtxtTitles_Notes.Text + "', " +
                    "pubdate = '" + dtpTitles_Date.Text + 

                    "' WHERE title_id = '" + mskTitle_ID.Text + "'");

                if (j)
                {
                    actualizarTabla("titles");
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Titles");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTitles_Guardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO titles( title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate) " +
                    "VALUES ('" + mskTitle_ID.Text + "','" +
                    txtTitle_name.Text + "','" +
                    txtTitle_Type.Text + "','" +
                    cmbTitles_publisherID.Text + "','" +
                    txtTitle_Price.Text + "','" +
                    txtTitle_Advance.Text + "','" +
                    txtTitle_Royalty.Text + "','" +
                    txtTitle_Sales.Text + "','" +
                    rtxtTitles_Notes.Text + "','" +
                    dtpTitles_Date.Text +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Titles", MessageBoxButtons.OK);
                    actualizarTabla("titles");
                }
                else
                {
                    MessageBox.Show("Error", "Sistema tabla Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTitles_Limpiar_Click(object sender, EventArgs e)
        {
            mskTitle_ID.Text = "";
            txtTitle_name.Text = "";
            txtTitle_Type.Text = "";
            cmbTitles_publisherID.Text = "";
            txtTitle_Price.Text = "";

            txtTitle_Advance.Text = "";
            txtTitle_Royalty.Text = "";
            txtTitle_Sales.Text = "";
            rtxtTitles_Notes.Text = "";
            dtpTitles_Date.Text = "";
        }

        private void btnTitles_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskTitle_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM titles WHERE title_id = '" + mskTitle_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskTitle_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
                        actualizarTabla("titles");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error tabla Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTitles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaSeleccionada = dgvTitles.Rows[e.RowIndex];


            mskTitle_ID.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtTitle_name.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtTitle_Type.Text = filaSeleccionada.Cells[2].Value.ToString();
            cmbTitles_publisherID.Text = filaSeleccionada.Cells[3].Value.ToString();
            txtTitle_Price.Text = filaSeleccionada.Cells[4].Value.ToString();

            txtTitle_Advance.Text = filaSeleccionada.Cells[5].Value.ToString();
            txtTitle_Royalty.Text = filaSeleccionada.Cells[6].Value.ToString();
            txtTitle_Sales.Text = filaSeleccionada.Cells[7].Value.ToString();
            rtxtTitles_Notes.Text = filaSeleccionada.Cells[8].Value.ToString();
            dtpTitles_Date.Text = filaSeleccionada.Cells[9].Value.ToString();
        }

        private void btnTitles_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM titles WHERE " + cmbTitles_SearchBy.Text + " = '" + txtTitles_Buscar.Text + "'");

            if (ds != null)
            {
                dgvTitles.DataSource = ds.Tables[0];
            }
        }

        private void btnTitles_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla("titles");
        }
    } // end class frmPrincipal
} // end namespace