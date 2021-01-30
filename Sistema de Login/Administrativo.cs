using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin;

namespace Sistema_de_Login
{
    public partial class Administrativo : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public Administrativo()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void Administrativo_Load(object sender, EventArgs e)
        {
           lb_nome.Text = Classes.Global.nome;//recebe o nome salvo na variavel global
        }
    }
}
