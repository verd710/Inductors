using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Inductors
{
    public partial class WireTypes : Form
    {
        List<String> wireTypes;

        public WireTypes()
        {
            InitializeComponent();

            wireTypes = Main.ReadWireTypes();

            UpdateListbox();
        }

        void WriteWireTypes()
        {
            String text = "";
            String fileName = "WIRETYPES.txt";

            foreach (String wire in wireTypes)
                text += wire + " ";
            try
            {   // Open the text file using a stream writer.
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default))
                {
                    sw.Write(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write to file: " + ex.Message);
            }
        }

        public void UpdateListbox()
        {
            listBox_wireTypes.Items.Clear();
            foreach (String wire in wireTypes)
                listBox_wireTypes.Items.Add(wire);
        }

        private void listBox_wireTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_delete.Text = listBox_wireTypes.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                String deleteType = textBox_delete.Text;

                if (deleteType == "ПЭЛШО" || deleteType == "ПЭШО" || deleteType == "ЛЭШО" || deleteType == "ЛЭЛО" || deleteType == "ПЭЛО")
                    throw new Exception("Невозможно удалить встроенный тип");

                wireTypes.Remove(deleteType);
                WriteWireTypes();

                UpdateListbox();
                textBox_delete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                String newType = textBox_add.Text;
                if (newType.Length == 0)
                    throw new Exception("Введите название провода");

                if (newType.Contains(' ') || newType.Contains('*') || newType.Contains('|') || newType.Contains('\\') || newType.Contains(':') || newType.Contains('"') || newType.Contains('<') || newType.Contains('>') || newType.Contains('?') || newType.Contains('/'))
                    throw new Exception("Название провода не должно содержать пробелы или следующие символы: * | \\ : \" < > ? /");

                wireTypes.Add(newType);
                WriteWireTypes();

                UpdateListbox();
                textBox_add.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
