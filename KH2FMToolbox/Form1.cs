using System;
using System.Threading;
using KHMemLibrary;
using KHMemLibrary.KH2FMLib;

namespace KH2FMToolbox
{
    public partial class Form1 : Form
    {
        public static KH2FM KH2 = new KH2FM();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KH2.RefillHP();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KH2.RefillMP();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KH2.RefillDrive();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KH2.Munny(999999);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KH2.ModifyConsumable(Consumable.Elixir, 88);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KH2.ModifyMaterial(Material.OrichalcumPlus, 88);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KH2.SoftReset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kingdom Key")
                KH2.AddWeaponSora(Keyblade.KingdomKey);
            else if (comboBox1.Text == "Ultima Weapon")
                KH2.AddWeaponSora(Keyblade.UltimaWeapon);
            else if (comboBox1.Text == "Oblivion")
                KH2.AddWeaponSora(Keyblade.Oblivion);
            else if (comboBox1.Text == "Oathkeeper")
                KH2.AddWeaponSora(Keyblade.Oathkeeper);
            else if (comboBox1.Text == "Wishing Lamp")
                KH2.AddWeaponSora(Keyblade.WishingLamp);
            else if (comboBox1.Text == "Sleeping Lion")
                KH2.AddWeaponSora(Keyblade.SleepingLion);
            else MessageBox.Show("Invalid Keyblade");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Save the Queen+")
                KH2.AddWeaponDonald(Staff.SaveTheQueenPlus);
            else if (comboBox2.Text == "Centurion+")
                KH2.AddWeaponDonald(Staff.CentrurionPlus);
            else MessageBox.Show("Invalid Staff");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        /*    if (comboBoxEvents.Text == "Sephiroth Battle")
            {
                if (KH2.isMapLoaded() == false)
                {
                    KH2.FPS(FPSValue.FPS30);
                    KH2.Event(0x04, 0x01, 0x4B);
                }
                else
                {
                    KH2.FPS(FPSValue.FPS60);
                }
            }
            else
            {
                MessageBox.Show("Invalid Event");
            }
            Thread.Sleep(5000);
            timer1.Stop(); */
        }   
        
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WorldID: " + KH2.FetchWorldID() + "\n" + "RoomID: " + KH2.FetchRoomID());
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{await KH2.FetchWorldText()}\n{await KH2.FetchRoomText()}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FPS: " + KH2.FetchFPS());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //int count = Convert.ToInt32(numericUpDown1.Value);
            //KH2.Level(count);
        }
    }
}