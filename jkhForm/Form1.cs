using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jkhForm.Properties;

namespace jkhForm
{
    public partial class Form1 : Form
    {
        float Gas;
        float Light;
        float ToiletHot;
        float KitchenHot;
        float ToiletCold;
        float KitchenCold;

        //float toPlan = 4104.08f;

        float[,] arrayPast =
        {
            {25.92f,493,498,5,129.6f},
            {123.62f,493,498,5,618.1f},
            {51.92f,1011,1020,9,467.28f},
            {6.72779f,138,148,10,67.2779f},
            {4.33f,14133,14291,158,684.14f}
        };        

        public Form1()
        {
            InitializeComponent();

            label55.Text = Settings.Default["TimeNow"].ToString();

            textBox8.Text = Settings.Default["arrayPast01"].ToString();
            textBox13.Text = Settings.Default["arrayPast11"].ToString();
            textBox18.Text = Settings.Default["arrayPast21"].ToString();
            textBox23.Text = Settings.Default["arrayPast31"].ToString();
            textBox28.Text = Settings.Default["arrayPast41"].ToString();
            textBox9.Text = Settings.Default["arrayPast02"].ToString();
            textBox14.Text = Settings.Default["arrayPast12"].ToString();
            textBox19.Text = Settings.Default["arrayPast22"].ToString();
            textBox24.Text = Settings.Default["arrayPast32"].ToString();
            textBox29.Text = Settings.Default["arrayPast42"].ToString();
            textBox10.Text = Settings.Default["arrayPast03"].ToString();
            textBox15.Text = Settings.Default["arrayPast13"].ToString();
            textBox20.Text = Settings.Default["arrayPast23"].ToString();
            textBox25.Text = Settings.Default["arrayPast33"].ToString();
            textBox30.Text = Settings.Default["arrayPast43"].ToString();
            textBox11.Text = Settings.Default["arrayPast04"].ToString();
            textBox16.Text = Settings.Default["arrayPast14"].ToString();
            textBox21.Text = Settings.Default["arrayPast24"].ToString();
            textBox26.Text = Settings.Default["arrayPast34"].ToString();
            textBox31.Text = Settings.Default["arrayPast44"].ToString();

            textBox7.Text = Settings.Default["arrayPast1"].ToString();
            textBox12.Text = Settings.Default["arrayPast2"].ToString();
            textBox17.Text = Settings.Default["arrayPast3"].ToString();
            textBox22.Text = Settings.Default["arrayPast4"].ToString();
            textBox27.Text = Settings.Default["arrayPast5"].ToString();

            textBox56.Text = Settings.Default["arrayPast1"].ToString();
            textBox51.Text = Settings.Default["arrayPast2"].ToString();
            textBox46.Text = Settings.Default["arrayPast3"].ToString();
            textBox41.Text = Settings.Default["arrayPast4"].ToString();
            textBox36.Text = Settings.Default["arrayPast5"].ToString();

            textBox32.Text = Settings.Default["Итого_начислено_по_плану"].ToString();

            arrayPast[0, 0] = Convert.ToSingle(textBox7.Text);
            arrayPast[1, 0] = Convert.ToSingle(textBox12.Text);
            arrayPast[2, 0] = Convert.ToSingle(textBox17.Text);
            arrayPast[3, 0] = Convert.ToSingle(textBox22.Text);
            arrayPast[4, 0] = Convert.ToSingle(textBox27.Text);
            arrayPast[0, 1] = Convert.ToSingle(textBox8.Text);
            arrayPast[1, 1] = Convert.ToSingle(textBox13.Text);
            arrayPast[2, 1] = Convert.ToSingle(textBox18.Text);
            arrayPast[3, 1] = Convert.ToSingle(textBox23.Text);
            arrayPast[4, 1] = Convert.ToSingle(textBox28.Text);
            //arrayPast[0, 2] = Convert.ToSingle(textBox9.Text);
            //arrayPast[1, 2] = Convert.ToSingle(textBox14.Text);
            //arrayPast[2, 2] = Convert.ToSingle(textBox19.Text);
            //arrayPast[3, 2] = Convert.ToSingle(textBox24.Text);
            //arrayPast[4, 2] = Convert.ToSingle(textBox29.Text);
            arrayPast[0, 3] = Convert.ToSingle(textBox10.Text);
            arrayPast[1, 3] = Convert.ToSingle(textBox15.Text);
            arrayPast[2, 3] = Convert.ToSingle(textBox20.Text);
            arrayPast[3, 3] = Convert.ToSingle(textBox25.Text);
            arrayPast[4, 3] = Convert.ToSingle(textBox30.Text);
            arrayPast[0, 4] = Convert.ToSingle(textBox11.Text);
            arrayPast[1, 4] = Convert.ToSingle(textBox16.Text);
            arrayPast[2, 4] = Convert.ToSingle(textBox21.Text);
            arrayPast[3, 4] = Convert.ToSingle(textBox26.Text);
            arrayPast[4, 4] = Convert.ToSingle(textBox31.Text);
                       
            label59.Text = Settings.Default["totalPast"].ToString();
            label57.Text = Settings.Default["toPayPast"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0 && textBox3.Text.Length == 0 && textBox4.Text.Length == 0 && textBox6.Text.Length == 0 && textBox5.Text.Length == 0)
            {
                MessageBox.Show("Некоторые позиции не заполнены\n или имеют неверное значение.", "!!! Ошибка !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();                
            }
            
            Gas = Convert.ToInt32(textBox1.Text);
            Light = Convert.ToInt32(textBox2.Text);
            ToiletHot = Convert.ToInt32(textBox3.Text);
            KitchenHot = Convert.ToInt32(textBox4.Text);
            ToiletCold = Convert.ToInt32(textBox6.Text);
            KitchenCold = Convert.ToInt32(textBox5.Text);

            float[,] arrayNow =
            {
                {25.92f,arrayPast[0, 2],ToiletHot + KitchenHot,0,0},
                {123.62f,arrayPast[1, 2],ToiletHot + KitchenHot,0,0},
                {51.92f,arrayPast[2, 2],ToiletCold + KitchenCold,0,0},
                {6.72779f,arrayPast[3, 2],Gas,0,0},
                {4.33f,arrayPast[4, 2],Light,0,0}
            };
            // Первый столбец
            arrayNow[0, 0] = Convert.ToSingle(textBox56.Text);
            arrayNow[1, 0] = Convert.ToSingle(textBox51.Text);
            arrayNow[2, 0] = Convert.ToSingle(textBox46.Text);
            arrayNow[3, 0] = Convert.ToSingle(textBox41.Text);
            arrayNow[4, 0] = Convert.ToSingle(textBox36.Text);
            // Второй столбец
            arrayNow[0, 1] = Convert.ToSingle(textBox9.Text);
            arrayNow[1, 1] = Convert.ToSingle(textBox14.Text);
            arrayNow[2, 1] = Convert.ToSingle(textBox19.Text);
            arrayNow[3, 1] = Convert.ToSingle(textBox24.Text);
            arrayNow[4, 1] = Convert.ToSingle(textBox29.Text);
            // Разница
            arrayNow[0, 3] = arrayNow[0, 2] - arrayNow[0, 1];
            arrayNow[1, 3] = arrayNow[1, 2] - arrayNow[1, 1];
            arrayNow[2, 3] = arrayNow[2, 2] - arrayNow[2, 1];
            arrayNow[3, 3] = arrayNow[3, 2] - arrayNow[3, 1];
            arrayNow[4, 3] = arrayNow[4, 2] - arrayNow[4, 1];
            // Всего
            arrayNow[0, 4] = arrayNow[0, 3] * arrayNow[0, 0];
            arrayNow[1, 4] = arrayNow[1, 3] * arrayNow[1, 0];
            arrayNow[2, 4] = arrayNow[2, 3] * arrayNow[2, 0];
            arrayNow[3, 4] = arrayNow[3, 3] * arrayNow[3, 0];
            arrayNow[4, 4] = arrayNow[4, 3] * arrayNow[4, 0];

            float toPlan = Convert.ToSingle(textBox32.Text); ;

            // Итого по приборам учета
            float total = arrayNow[0, 4] + arrayNow[1, 4] + arrayNow[2, 4] + arrayNow[3, 4] + arrayNow[4, 4];
            float totalPast = arrayPast[0, 4] + arrayPast[1, 4] + arrayPast[2, 4] + arrayPast[3, 4] + arrayPast[4, 4];
            // Всего к оплате
            float toPay = total + toPlan;
            float toPayPast = totalPast + toPlan;

            DateTime dateTimeNow = new DateTime();
            dateTimeNow = DateTime.Now;                     
            
            // Вывод данных

            // П.П.
            label18.Text = textBox9.Text;
            label22.Text = textBox14.Text;
            label26.Text = textBox19.Text;
            label30.Text = textBox24.Text;
            label34.Text = textBox29.Text;
            // П.П.
            label19.Text = Convert.ToString(ToiletHot + KitchenHot);
            label23.Text = Convert.ToString(ToiletHot + KitchenHot);
            label27.Text = Convert.ToString(ToiletCold + KitchenCold);
            label31.Text = Convert.ToString(Gas);
            label35.Text = Convert.ToString(Light);
            // Разница
            label20.Text = Convert.ToString(arrayNow[0, 3]);
            label24.Text = Convert.ToString(arrayNow[1, 3]);
            label28.Text = Convert.ToString(arrayNow[2, 3]);
            label32.Text = Convert.ToString(arrayNow[3, 3]);
            label36.Text = Convert.ToString(arrayNow[4, 3]);
            // Всего
            label21.Text = Convert.ToString(arrayNow[0, 3] * arrayNow[0, 0]);
            label25.Text = Convert.ToString(arrayNow[1, 3] * arrayNow[1, 0]);
            label29.Text = Convert.ToString(arrayNow[2, 3] * arrayNow[2, 0]);
            label33.Text = Convert.ToString(arrayNow[3, 3] * arrayNow[3, 0]);
            label48.Text = Convert.ToString(arrayNow[4, 3] * arrayNow[4, 0]);

            label53.Text = Convert.ToString(dateTimeNow);
            label50.Text = Convert.ToString(total);
            label51.Text = Convert.ToString(toPay);

            label59.Text = Convert.ToString(totalPast);
            label57.Text = Convert.ToString(toPayPast);          
            
        }
        // Сохранение
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Сохранить рассчитанные данные?", "!!! Внимание !!!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Settings.Default["TimeNow"] = label53.Text;

                Settings.Default["totalPast"] = Convert.ToSingle(label50.Text);
                Settings.Default["toPayPast"] = Convert.ToSingle(label51.Text);

                Settings.Default["arrayPast01"] = Convert.ToSingle(label18.Text);
                Settings.Default["arrayPast11"] = Convert.ToSingle(label22.Text);
                Settings.Default["arrayPast21"] = Convert.ToSingle(label26.Text);
                Settings.Default["arrayPast31"] = Convert.ToSingle(label30.Text);
                Settings.Default["arrayPast41"] = Convert.ToSingle(label34.Text);
                Settings.Default["arrayPast02"] = Convert.ToSingle(label19.Text);
                Settings.Default["arrayPast12"] = Convert.ToSingle(label23.Text);
                Settings.Default["arrayPast22"] = Convert.ToSingle(label27.Text);
                Settings.Default["arrayPast32"] = Convert.ToSingle(label31.Text);
                Settings.Default["arrayPast42"] = Convert.ToSingle(label35.Text);
                Settings.Default["arrayPast03"] = Convert.ToSingle(label20.Text);
                Settings.Default["arrayPast13"] = Convert.ToSingle(label24.Text);
                Settings.Default["arrayPast23"] = Convert.ToSingle(label28.Text);
                Settings.Default["arrayPast33"] = Convert.ToSingle(label32.Text);
                Settings.Default["arrayPast43"] = Convert.ToSingle(label36.Text);
                Settings.Default["arrayPast04"] = Convert.ToSingle(label21.Text);
                Settings.Default["arrayPast14"] = Convert.ToSingle(label25.Text);
                Settings.Default["arrayPast24"] = Convert.ToSingle(label29.Text);
                Settings.Default["arrayPast34"] = Convert.ToSingle(label33.Text);
                Settings.Default["arrayPast44"] = Convert.ToSingle(label48.Text);

                Settings.Default["arrayPast1"] = Convert.ToSingle(textBox56.Text);
                Settings.Default["arrayPast2"] = Convert.ToSingle(textBox51.Text);
                Settings.Default["arrayPast3"] = Convert.ToSingle(textBox46.Text);
                Settings.Default["arrayPast4"] = Convert.ToSingle(textBox41.Text);
                Settings.Default["arrayPast5"] = Convert.ToSingle(textBox36.Text);

                Settings.Default["Итого_начислено_по_плану"] = Convert.ToSingle(textBox32.Text);

                Settings.Default.Save();

                MessageBox.Show("Данные успешно сохранены.", "");
            }


        }
    }
}
