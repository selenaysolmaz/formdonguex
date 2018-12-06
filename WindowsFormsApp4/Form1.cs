using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int[] Dizi = { 10, 20, 25, 28, 34 };
        int Toplam;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnfor_Click(object sender, EventArgs e)
        {
            ForDongu();
            Temizle();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            WhileDongu();
            Temizle();
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            DoWhileDongu();
            Temizle();
        }

        private void btnıenum_Click(object sender, EventArgs e)
        {
           IenmDongu();
            Temizle();
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
           ForEachdDongu();
            Temizle();
        }

        public void ForDongu()
        {
            for (int i = 0; i < Dizi.Length; i++)
            {
                Toplam+= Dizi[i];
                lfor.Items.Add(Dizi[i]);
            }
            lfor.Items.Add("Toplam = : " +Toplam);
        }
        public void WhileDongu()
        {
            int i= 0;
            lwhile.Items.Clear();
            while (i < Dizi.Length)
            {
                
                lwhile.Items.Add(Dizi[i]);
                Toplam += Dizi[i];
                i++;
            }
            lwhile.Items.Add("Toplam = : " + Toplam);
        }
        public void DoWhileDongu()
        {
            int i = 0;
            do
            {
                Toplam += Dizi[i];
                ldowhile.Items.Add(Dizi[i]);
                i++;
            }
            while (i < Dizi.Length);
            ldowhile.Items.Add("Toplam = : " + Toplam);
        }
        public void IenmDongu()
        {
            lıenum.Items.Clear();
            int i = 0;
            IEnumerator IENum = Dizi.GetEnumerator();
            while (IENum.MoveNext())
            {
                lıenum.Items.Add(IENum.Current);
                Toplam += Dizi[i];
                i++;

            }
            lıenum.Items.Add("Toplam = : " + Toplam);
        }

        public void ForEachdDongu()
        {
            lforeach.Items.Clear();
            foreach (var item in Dizi)
            {
                lforeach.Items.Add(item);
                Toplam += item;
            }
            lforeach.Items.Add("Toplam = : " + Toplam);
        }
        public void Temizle()
        {
            Toplam = 0;
        }

    }
}
