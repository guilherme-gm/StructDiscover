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

namespace Structurer
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create("C:/struct.bin")))
            {
                bw.Write(Convert.ToInt32(100));
                bw.Write(Encoding.ASCII.GetBytes("Testes"));
                bw.Write(Convert.ToInt16(35));
                bw.Write(Convert.ToInt32(3));
                // Block (3x)
                bw.Write(Convert.ToInt32(10));
                bw.Write(Encoding.ASCII.GetBytes("Lorem"));
                //
                bw.Write(Convert.ToInt32(12));
                bw.Write(Encoding.ASCII.GetBytes("Ipsum"));
                //
                bw.Write(Convert.ToInt32(14));
                bw.Write(Encoding.ASCII.GetBytes("Dolor"));

                bw.Close();
            }
        }

        private void btn_Parse_Click(object sender, EventArgs e)
        {
            StructData _struct = new StructData();

            foreach (DataGridViewRow row in data_Struct.Rows)
            {
                if(row.Cells["str_type"].Value != null)
                    _struct.Add((StructData.ElementType)Enum.Parse(typeof(StructData.ElementType), row.Cells["str_type"].Value.ToString()), row.Cells["str_name"].Value.ToString(), row.Cells["str_size"].Value.ToString());
            }

            BinaryParser bp = new BinaryParser();
            if (bp.Parse(_struct, txt_FileName.Text))
            {
                foreach (string key in bp.Result.Keys)
                {
                    grid_Result.Rows.Add(new object[] { key, bp.Result[key] });
                    rtxt_Result.AppendText(key + " => " + bp.Result[key] + "\r\n");
                }

                MessageBox.Show("Done", "Done.");
            }
            else
            {
                MessageBox.Show("Error", "An error occurred while trying to parse the file.");
                rtxt_Result.AppendText(bp.Result["___ERROR"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_Struct.Rows.Add(new object[] { "Int32", "", "id" });
            data_Struct.Rows.Add(new object[] { "String", "6", "name" });
            data_Struct.Rows.Add(new object[] { "Int16", "", "type" });
            data_Struct.Rows.Add(new object[] { "Int32", "", "count" });

            data_Struct.Rows.Add(new object[] { "Block", "val:count", "subs" });
            data_Struct.Rows.Add(new object[] { "Int32", "", "id" });
            data_Struct.Rows.Add(new object[] { "String", "5", "msg" });
            data_Struct.Rows.Add(new object[] { "BlockEnd", "", "" });
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_FileName.Text = openFileDialog1.FileName;
            }
        }

        private void openStructToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_StructFile.Text = openFileDialog1.FileName;
                if (OpenStruct(openFileDialog1.FileName))
                {
                    MessageBox.Show("Done", "Struct file loaded successfully");
                }
                else
                {
                    MessageBox.Show("Error", "An error occurred. Try again.");
                }
            }
        }

        private void saveStructToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (SaveStruct(saveFileDialog1.FileName))
                {
                    txt_StructFile.Text = saveFileDialog1.FileName;
                    MessageBox.Show("Done", "Struct file saved successfully");
                }
                else
                {
                    MessageBox.Show("Error", "An error occurred. Try again.");
                }
            }
        }

        private bool OpenStruct(string dir)
        {
            try
            {
                string[] str = File.ReadAllLines(dir);

                data_Struct.Rows.Clear();

                foreach (string str_line in str)
                {
                    data_Struct.Rows.Add(str_line.Split('\t'));
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool SaveStruct(string dir)
        {
            try
            {
                List<string> str = new List<string>();

                foreach (DataGridViewRow row in data_Struct.Rows)
                {
                    if (row.Cells["str_type"].Value == null) continue;
                    str.Add(row.Cells["str_type"].Value.ToString() + '\t' + row.Cells["str_size"].Value.ToString() + '\t' + row.Cells["str_name"].Value.ToString());
                }

                File.WriteAllLines(dir, str.ToArray());
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        
    }
}
