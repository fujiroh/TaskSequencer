using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSequenceApp
{
    public partial class MainForm : Form
    {
        private readonly ApplicationController _controller;
        
        public MainForm()
        {
            InitializeComponent();
            _controller = new ApplicationController();
        }
        
        
        
    }
}