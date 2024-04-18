using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbAtividade.SelectedIndex.Equals(-1)) 
            { 
                MessageBox.Show("Insira uma opção válida de atividade física!","Atenção!", MessageBoxButton.OK)
            }
        }
    }
}
