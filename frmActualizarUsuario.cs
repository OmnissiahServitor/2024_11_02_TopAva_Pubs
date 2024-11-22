using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmActualizarUsuario : Form
    {
        DataSet ds;
        string emp_id;

        public frmActualizarUsuario(string fname, string lname, string emp_id)
        {
            InitializeComponent();
            this.CenterToScreen();

            txt_FirstName.Text = fname;
            txt_LastName.Text = lname;
            this.emp_id = emp_id;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();
            int job_id = 0;
            int level_access = 0;

            bool j = dt.ejecutarABC("UPDATE employee " +
                "SET fname = '" + txt_FirstName.Text + "', " +
                "lname = '" + txt_LastName.Text + "' " + 
                "WHERE emp_id = '" + emp_id + "'");

            if (j)
            {
                MessageBox.Show("Datos Actualizados Correctamente", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);

                ds = dt.consulta("SELECT job_id FROM employee WHERE emp_id = '" +
                emp_id +
                "'");

                if (ds.Tables[0].Rows.Count > 0) // Asegurarse de que hay filas en la tabla
                {
                    job_id = int.Parse(ds.Tables[0].Rows[0]["job_id"].ToString());
                }

                //MessageBox.Show("Job id = " + job_id);

                if (job_id == 1 || (job_id <= 14 && job_id >= 12)) // nivel minimo
                    level_access = 1;
                else if (job_id <= 11 && job_id >= 7) // nivel medio
                    level_access = 2;
                else if (job_id <= 6 && job_id >= 2 || job_id == 15) // nivel total
                    level_access = 3;


                frmPrincipal frm = new frmPrincipal(emp_id, level_access);
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Actualizacion NO realizada.", "Error - Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    } // end class
} // end namespace
