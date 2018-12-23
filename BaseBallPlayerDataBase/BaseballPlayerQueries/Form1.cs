using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BaseballPlayerQueries
{
    public partial class DisplayPlayerForm : Form
    {
        private BaseBallPlayerDataBase.BaseballEntities dbcontext = new BaseBallPlayerDataBase.BaseballEntities();
        public DisplayPlayerForm()
        {
            InitializeComponent();
        }
        private void DBObjLoad()
        {
            var players =
                           from player in dbcontext.Players
                           orderby player.FirstName, player.LastName
                           select player;

            playerBindingSource.DataSource = players.ToList();
        }


        private void DisplayPlayerForm_Load(object sender, EventArgs e)
        {
            DBObjLoad();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_textBox.Text == "") return;

            string lastName = search_textBox.Text;

            var players =
                from player in dbcontext.Players
                orderby player.FirstName, player.LastName
                where player.LastName == lastName
                select player;
            playerBindingSource.DataSource = players.ToList();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            DBObjLoad();
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
