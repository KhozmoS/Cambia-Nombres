using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CambiaNombres
{
    public partial class OneForm : MetroForm
    {
        public OneForm()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = fbd.SelectedPath;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
              
                modifyOneFolder();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }
        public void modifyOneFolder()
        {
            string[] files = Directory.GetFiles(textPath.Text);
            string name = textNombre.Text;

            int matchErrors = 0;
            int numberFail = 0;

            for (int i = 0; i < files.Length; i++)
            {
                string source = files[i];

                int lastSlash = source.LastIndexOf(@"\");
                int lastPoint = source.LastIndexOf('.');

                string path = source.Substring(0, lastSlash + 1);
                string complement = source.Substring(lastSlash + 1);
                string original = complement;

                complement = complement.ToLower();
                if (!complement.Contains(name.ToLower()))
                {
                    matchErrors++;
                    continue;
                }

                string result = transformar(complement, name);
                if (result == "-1")
                {
                    numberFail++;
                    continue;
                }

                string destination = path + result + source.Substring(lastPoint);
                if (!File.Exists(destination))
                    File.Move(source, destination);
                else
                {
                    MessageBox.Show("Archivo ya existe! - " + result, "Mensage de Confirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (numberFail != 0)
            {
                MessageBox.Show("Algunos archivos estaban faltos de capitulos: (" + numberFail.ToString() + ")", "Error en coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (matchErrors != 0)
            {
                MessageBox.Show("Algunos no coincidian con el nombre esperado: (" + matchErrors.ToString() + ")", "Error en coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Operacion Completada con Exito!", "Mensage de Confirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
     
        private string transformar( string source , string name )
        {
            source = source.Replace(name.ToString().ToLower(), "");
            // MessageBox.Show( source );
            string number = "";
            bool ok = false;
            for( int i = 0; i < source.Length; i++ )
            {
                if (source[i] >= '0' && source[i] <= '9')
                {
                    ok = true;
                    number += source[i];
                }
                else if ( ok ) break;
            }

            if (number.Length == 0)
                return "-1";

            while (number.Length < 3) number = "0" + number;


            return "[" + number + "] " + name + " [PikyCopy]";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textNombre.ResetText();
            textPath.ResetText();
        }

    }
}
