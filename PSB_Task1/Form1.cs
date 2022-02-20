using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CsvHelper;

namespace PSB_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetInfo_button_Click(object sender, EventArgs e)
        {
            string processNames = ProcessNames_textBox.Text;
            if (processNames.Length == 0)
            {
                MessageBox.Show("Текстовое поле пустое. Введите имя процесса(ов).", "Внимание!");
                //MessageBox.Show(Environment.UserName);
            }
            else
            {
                List<string> processList = processNames.Replace(" ", "").Split(',', ';').ToList();
                List<ProcessInfo> requiredProcesses = GetProcessInfo(processList);
                if (requiredProcesses.Count != 0)
                {
                    WriteToCSV(requiredProcesses);
                }
                else { MessageBox.Show("Процессы с такими именами не найдены.", "Внимание!"); }
            }

        }

        private List<ProcessInfo> GetProcessInfo(List<string> processes)
        {
            List<ProcessInfo> result = new List<ProcessInfo>();
            foreach (string name in processes)
            {
                Process[] sameNamedProcesses = Process.GetProcessesByName(name);
                foreach (var proc in sameNamedProcesses)
                {
                    string priority;
                    try { priority = proc.PriorityClass.ToString(); }
                    catch(Exception ex) { priority = ex.Message; }
                    result.Add(new ProcessInfo { Name = proc.ProcessName, ID = proc.Id.ToString(), PriorityClass = priority });
                    
                }
            }
            return result;
        }

        private void WriteToCSV(List<ProcessInfo> outputData)
        {
            string dir = @"C:\Users\"+ Environment.UserName + @"\Documents";
            string file = @"\ProcessInfo.csv";
            if (!Directory.Exists(dir))  dir = ChooseFolder();
            if (dir != null)
            {
                string path = dir + file;
                using (TextWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    writer.WriteLine($"Name; ID; PriorityClass");
                    foreach (var line in outputData)
                    {
                        writer.WriteLine($"{line.Name};{line.ID};{line.PriorityClass}");
                    }
                }
                OpenCSV(path);
            }
            else
            {
                MessageBox.Show("Невозможно сохранить файл: не выбран каталог.", "Невозможно сохранить файл!");
            }
            
        }

        private void ProcessNames_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetInfo_button_Click(this, EventArgs.Empty);
            }
        }

        public string ChooseFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                return folderBrowser.SelectedPath;
            }
            else
            {
                return null;
            }
        }
        private void OpenCSV (string path)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType != null)
            {
                Process.Start(path);
            }
            else
            {
                Process.Start(path);
            }
        }
    }
}

