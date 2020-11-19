using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AspnetCompilerGUI
{
    public partial class FormGUI : Form
    {
        public FormGUI()
        {
            InitializeComponent();
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            //Stringhe
            string compilerLocation = Environment.SystemDirectory.Replace("system32","") + @"Microsoft.NET\Framework\v2.0.50727\aspnet_compiler.exe";
            string compilerArguments = string.Empty;
            
            //Opzioni
            if (checkOverwrite.Checked)
            {
                compilerArguments = compilerArguments + " -f";
            }
            if (checkFixed.Checked)
            {
                compilerArguments = compilerArguments + " -fixednames";
            }
            if (checkUpdateable.Checked) 
            {
                compilerArguments = compilerArguments + " -u";
            }
            if (checkDebug.Checked)
            {
                compilerArguments = compilerArguments + " -d";
            }
            if (checkFull.Checked)
            {
                compilerArguments = compilerArguments + " -c";
            }

            //Nomi directory
            if (radioPhysical.Checked)
            {
                compilerArguments = compilerArguments + " -p \"" + textSourcePhysical.Text +"\" -v / ";
            }
            else if (radioVirtual.Checked)
            {
                compilerArguments = compilerArguments + " -v \"" + textSourceVirtual.Text + "\" ";
            }
            else if (radioMetabase.Checked)
            {
                compilerArguments = compilerArguments + " -m " + textSourceMetabase.Text;
            }

            //Destinazione
            if (checkTarget.Checked)
            {
                compilerArguments = compilerArguments + "\"" + textTarget.Text + "\"";
            }

            //Nessuna scritta
            compilerArguments = compilerArguments + " -nologo";

            //Info sul processo
            ProcessStartInfo compilerProcessInfo = new ProcessStartInfo(compilerLocation, compilerArguments);
            compilerProcessInfo.RedirectStandardOutput = true;
            compilerProcessInfo.RedirectStandardError = true;
            compilerProcessInfo.UseShellExecute = false;
            compilerProcessInfo.CreateNoWindow = true;

            //Avvio processo
            Process compilerProcess = new Process();
            compilerProcess.StartInfo = compilerProcessInfo;
            compilerProcess.Start();

            //Risultato
            textResult.Text = compilerProcess.StandardOutput.ReadToEnd();
            textResult.Text = textResult.Text + compilerProcess.StandardError.ReadToEnd();

            //Uscita
            compilerProcess.WaitForExit();//*/



            if (radioMergeNone.Checked == false)
            {
                string mergeLocation = AspNetMergePath();
                string mergeArguments = string.Empty;
                
                if (checkTarget.Checked)
                {
                    mergeArguments = textTarget.Text;
                }

                //Mergin
                if (radioMergeSingle.Checked)
                {
                    mergeArguments = mergeArguments + " -o " + textMergeSingle.Text;

                }
                else if (radioMergeMulti.Checked)
                {
                    mergeArguments = mergeArguments + " -prefix " + textMergeMulti.Text;
                }

                if (checkDebug.Checked)
                {
                    mergeArguments = mergeArguments + " -debug";
                }
                if (checkXML.Checked)
                {
                    mergeArguments = mergeArguments + " -xmldocs";
                }
                if (checkRemoveCompiled.Checked)
                {
                    mergeArguments = mergeArguments + " -r";
                }

                //Nessuna scritta
                mergeArguments = mergeArguments + " -nologo";

                //Info sul processo
                ProcessStartInfo mergeProcessInfo = new ProcessStartInfo(mergeLocation, mergeArguments);
                mergeProcessInfo.RedirectStandardOutput = true;
                mergeProcessInfo.RedirectStandardError = true;
                mergeProcessInfo.UseShellExecute = false;
                mergeProcessInfo.CreateNoWindow = true;

                //Avvio processo
                Process mergeProcess = new Process();
                mergeProcess.StartInfo = mergeProcessInfo;
                mergeProcess.Start();

                //Risultato
                textResult.Text = textResult.Text + mergeProcess.StandardOutput.ReadToEnd();

                //Uscita
                mergeProcess.WaitForExit();

            }
            
            MessageBox.Show("Build process completed.", "Asp.NET Compiler GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioMergeSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMergeSingle.Checked)
            {
                textMergeSingle.Enabled = true;
            }
            else
            {
                textMergeSingle.Enabled = false;
            }
        }

        private void radioMergeMulti_CheckedChanged(object sender, EventArgs e)
        {
            textMergeMulti.Enabled = radioMergeMulti.Checked;
        }

        private void checkTarget_CheckedChanged(object sender, EventArgs e)
        {
            textTarget.Enabled = checkTarget.Checked;
            buttonTarget.Enabled = checkTarget.Checked;
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textTarget.Text))
            {
                folderDialog.SelectedPath = textTarget.Text;
            }
            folderDialog.ShowNewFolderButton = true;
            folderDialog.Description = "Select the destination directory (or create new one) where the compiled files goes:";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textTarget.Text = folderDialog.SelectedPath;
            }
        }

        private void radioVirtual_CheckedChanged(object sender, EventArgs e)
        {
            textSourceVirtual.Enabled = radioVirtual.Checked;
        }

        private void radioPhysical_CheckedChanged(object sender, EventArgs e)
        {
            textSourcePhysical.Enabled = radioPhysical.Checked;
            buttonSourcePhysical.Enabled = radioPhysical.Checked;
        }

        private void radioMetabase_CheckedChanged(object sender, EventArgs e)
        {
            textSourceMetabase.Enabled = radioMetabase.Checked;
        }

        private void buttonSourcePhysical_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textSourcePhysical.Text))
            {
                folderDialog.SelectedPath = textSourcePhysical.Text;
            }
            folderDialog.ShowNewFolderButton = false;
            folderDialog.Description = "Select the physical source directory of web project to compile:";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                textSourcePhysical.Text = folderDialog.SelectedPath;
            }
        }

        public string AspNetMergePath()
        {
            if (File.Exists("aspnet_merge.exe"))
            {
                return "aspnet_merge.exe";
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Microsoft SDKs\Windows\v6.0A\bin\aspnet_merge.exe";
            if (File.Exists(path))
            {
                return path;
            }
            else
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\MSBuild\Microsoft\WebDeployment\v8.0\aspnet_merge.exe";
                if (File.Exists(path))
                {
                    return path;
                }
            }
            return string.Empty;
        }

        private void FormGUI_Load(object sender, EventArgs e)
        {
            if (File.Exists(AspNetMergePath()))
            {
                groupMerge.Enabled = true;
            }
            else
            {
                groupMerge.Enabled = false;
                textResult.Text = "No aspnet_merge.exe found.";
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
 

    }
}
