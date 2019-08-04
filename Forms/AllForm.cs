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

namespace CambiaNombres.Forms
{
    public partial class AllForm : MetroForm
    {
        string errorMatch = "";
        string errorNumb = "";
        public AllForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textPath.ResetText();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                errorMatch = "";
                errorNumb = "";
                modifyAllFolder( textPath.Text );

                if ( errorMatch != "")
                {
                    MessageBox.Show(errorMatch, "Errores de coincidencia" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                }
                if ( errorNumb != "" )
                {
                    MessageBox.Show(errorNumb, "Errores de numeracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Operacion Completada con Exito!", "Mensage de Confirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }

        }


        private void modifyAllFolder( string path )
        {
            
            string[] folders = Directory.GetDirectories( path );
            foreach (string folder in folders)
            {
                string[] files = Directory.GetFiles(folder);
                // DATA STRUCTURE FOR AVOID NAMES REPETITIONS CHECKS
                HashSet<string> HS = new HashSet<string>();

                foreach (string file in files)
                {
                    string name = getName( file );
                    if (name == "")
                        continue;
                    if ( HS.Contains(name) )
                        continue;
                    modifyOneFolder( name, files, folder );
                    HS.Add( name );
                }
                HS.Clear();
                // Recursivity for navigate the folders in dfs
                modifyAllFolder( folder );
            }                        
        }
        private string getName(string file)
        {
            
            if( file.Contains("PikyCopy") )
            {
                // OBTAINING ONLY THE NAME
                string suffix = file.Substring( file.LastIndexOf(@"\") + 1 );
                int first = suffix.IndexOf( " " );
                int last = suffix.LastIndexOf( " " );
                return suffix.Substring( first+1 , last-first-1 );
                
            }
            
            return "";
        }
        public void modifyOneFolder( string name , string [] files , string folder )
        {
            
            int matchErrors = 0;
            int numberFail = 0;
            
            for (int i = 0; i < files.Length; i++)
            {
                string source = files[i];
                // IF THE NAME OF SOME FILE CONTAIN SLASH CHARACTER ALGORITHM WILL CRASH
                int lastSlash = source.LastIndexOf(@"\");
                int lastPoint = source.LastIndexOf('.');

                string path = source.Substring(0, lastSlash + 1);
                string complement = source.Substring(lastSlash + 1);

                complement = complement.ToLower();

                if ( complement.Contains("pikycopy") )
                    continue;

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
                if( !File.Exists( destination ) )
                    File.Move(source, destination);
                else
                {
                    MessageBox.Show("Archivo ya existe! - " + destination + "\n", "Mensage de Confirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (numberFail != 0)
            {
                errorMatch += "Algunos archivos estaban faltos de capitulos: (" + numberFail.ToString() + ") - " + folder + " - " + name +  ".\n";
            }
            if (matchErrors != 0)
            {
                errorNumb += "Algunos no coincidian con el nombre esperado: (" + matchErrors.ToString() + ") - " + folder + " - " + name + ".\n";
            }
  
        }

        private string transformar(string source, string name)
        {
            // DELETING THE NAME FROM THE SOURCE FOR AVOID PROBLEMS IN CASE OF NAMES WITH NUMBERS
            source = source.Replace(name.ToString().ToLower(), "");
            // MessageBox.Show( source );
            string number = "";
            bool ok = false;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] >= '0' && source[i] <= '9')
                {
                    ok = true;
                    number += source[i];
                }
                else if (ok) break;
            }

            if ( number.Length == 0 )
                return "-1";

            while (number.Length < 3) number = "0" + number;


            return "[" + number + "] " + name + " [PikyCopy]";
        }

    }
}

