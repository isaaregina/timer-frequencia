using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Time
{
    class clsTimer
    {
        private Form1 _form1;

        public clsTimer(Form1 form1)
        {
            this.form1 = form1;
        }

        public Form1 form1
        {
            get { return _form1; }
            set { _form1 = value; }
        }

        public void start()
        {
            if (long.TryParse(form1.txtFrequencia.Text, out form1.testNumber) && form1.testNumber > 0)
            {
                if (form1.timer.Enabled) // se o timer já está habilitado
                {
                    form1.timer.Interval = Int32.Parse(form1.txtFrequencia.Text) * 1000; // atualiza o intervalo do timer
                }
                else // se o timer ainda não está habilitado
                {
                    form1.timer.Interval = Int32.Parse(form1.txtFrequencia.Text) * 1000;
                    form1.timer.Enabled = true;

                }
            }
            else if (long.TryParse(form1.txtFrequencia.Text, out form1.testNumber) && form1.testNumber <= 0)
            {
                MessageBox.Show("Insira um valor maior que zero", "ERRO");
            }
            else if (!long.TryParse(form1.txtFrequencia.Text, out form1.testNumber) && form1.txtFrequencia.Text == "")
            {
                MessageBox.Show("Frequência não pode ser vazia", "AVISO");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor inteiro à frequência.", "ERROR");
                form1.txtFrequencia.Text = "";
            }
            
        }

        public void stop()
        {
            if (form1.timer.Enabled)
            {
                form1.timer.Enabled = false;
            }
        }

        public void reset()
        {
            form1.segundos = 0;
            form1.minutos = 0;
            form1.horas = 0;

            form1.timer.Enabled = false;

            form1.tempo.Text = "00 : 00 : 00";
        }

        public void exit()
        {
            form1.Close();
        }

        public void Count1(object source, ElapsedEventArgs e)
        {

            form1.segundos++;
            if (form1.segundos == 60)
            {
                form1.segundos = 0;
                form1.minutos++;
                if (form1.minutos == 60)
                {
                    form1.minutos = 0;
                    form1.horas++;
                }
            }

            form1.Invoke((MethodInvoker)delegate {
                form1.tempo.Text = $"{form1.horas:D2} : {form1.minutos:D2} : {form1.segundos:D2}";
            });
        }
    }
}
    

