using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using MatchManagement;

namespace FifaManager
{
    public partial class FifaManagerMdi : Form
    {
         public FifaManagerMdi()
        {
            InitializeComponent();
        }
        private void ChampionnatMnu_Click(object sender, EventArgs e)
        {
            ChampionnatMdi ofrm = new ChampionnatMdi();
            try
            {
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        private void EquipesMenu_Click(object sender, EventArgs e)
        {
            EquipesMdi ofrm = new EquipesMdi();
            try
            {
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void GestionMatchsMnu_Click(object sender, EventArgs e)
        {
            GestionMatchsMdi ofrm = new GestionMatchsMdi();
            try
            {
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void JoueursMnu_Click(object sender, EventArgs e)
        {
            JoueursMdi ofrm = new JoueursMdi();
            try
            {
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void ClassementMnu_Click(object sender, EventArgs e)
        {
            ClassementMdi ofrm = new ClassementMdi();
            try
            {
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
