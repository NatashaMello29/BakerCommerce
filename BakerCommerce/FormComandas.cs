using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        Model.Usuario Usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }
    }
}
