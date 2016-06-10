using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace AtomThai
{
    public partial class Calculator : Form
    {

        public string TextTotal;
        public StringBuilder _strB = new StringBuilder();
        public Calculator()
        {
            InitializeComponent();
            TextTotal = txtTotal.Text;
        }

        public class CalculatorF
        {
            private float _Total;

            public float Total
            {
                get { return _Total; }
                set { _Total = value; }
            }

        }

        public void TextFormat(string strA)
        {

            if (txtTotal.Text == "0" && strA == "0")
                return;
         
            _strB.Append(strA);
            txtTotal.Text = _strB.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            object item = sender;
            //using System.Reflection;
            PropertyInfo pi = item.GetType().GetProperty("Name");
            String strName = (String)(pi.GetValue(item, null));

            switch (strName)
            {
                case "btn1":
                    TextFormat("1");
                    break;
                case "btn2":
                    TextFormat("2");
                    break;
                case "btn3":
                    TextFormat("3");
                    break;
                case "btn4":
                    TextFormat("4");
                    break;
                case "btn5":
                    TextFormat("5");
                    break;
                case "btn6":
                    TextFormat("6");
                    break;
                case "btn7":
                    TextFormat("7");
                    break;
                case "btn8":
                    TextFormat("8");
                    break;
                case "btn9":
                    TextFormat("9");
                    break;
                case "btn0":
                    TextFormat("0");
                    break;
                case "btnPoint":
                    TextFormat(".");
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            _strB = new StringBuilder();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            string strTemp;
            strTemp = _strB.ToString();
            if (strTemp.Contains("."))
                return;

            if (txtTotal.Text == "0")
            {
                _strB.Append("0.");
                txtTotal.Text = _strB.ToString();
            }
            else
            {
                TextFormat(".");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int iTemp;
<<<<<<< HEAD
            string strTemp = _strB.ToString();
            iTemp = strTemp.Length;
            strTemp.Remove(iTemp - 2);
=======
            string strTemp;

            if (txtTotal.Text == "0.")
                return;

            strTemp = _strB.ToString();            
            iTemp = strTemp.Length;

            if (iTemp == 1)
            {
                txtTotal.Text = "0.";
                return;
            }

            strTemp = strTemp.Remove(iTemp - 1);
>>>>>>> origin/StuffRegister
            _strB = new StringBuilder();
            _strB.Append(strTemp);
        }
    }
}
