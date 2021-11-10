using System;
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
    }
}