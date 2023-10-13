using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Time
{
    public partial class Form1 : Form
    {
        private int _segundos = 0;
        private int _minutos = 0;
        private int _horas = 0;
        private System.Timers.Timer _timer;
        private clsTimer _clsTimer;
        public long testNumber = 0L;

        public Form1()
        {
            InitializeComponent();

            _timer = new System.Timers.Timer();
            _clsTimer = new clsTimer(this);
            _clsTimer.form1 = this;
            _timer.Elapsed += new ElapsedEventHandler(Contador);
            _timer.AutoReset = true;
            _timer.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _clsTimer.start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _clsTimer.stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _clsTimer.reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _clsTimer.exit();
        }

        private void txtFrequencia_TextChanged(object sender, EventArgs e)
        {

        }

        public int segundos
        {
            get { return _segundos; }
            set { _segundos = value; }
        }
        public int minutos
        {
            get { return _minutos; }
            set { _minutos = value; }
        }
        public int horas
        {
            get { return _horas; }
            set { _horas = value; }
        }
        public System.Timers.Timer timer
        {
            get { return _timer; }
        }

        private void Contador(object source, ElapsedEventArgs e)
        {
            _clsTimer.Count1(source, e);

        }
    }
}

        