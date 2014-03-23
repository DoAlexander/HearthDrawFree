using FileHelpers;
using HearthDrawFree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HearthDrawFree
{
    public partial class HearthDrawFree : Form
    {
        public FileHelperEngine engine = new FileHelperEngine(typeof(card));

        private
            List<Deck> decks = new List<Deck>();
            Assembly _assembly;
            StreamReader _databaseReader;

        public HearthDrawFree()
        {
            InitializeComponent();
            
        }

        public void GrabCards()
        {
            //object database =  Properties.Resources.ResourceManager.GetStream("Database");
            //Properties.Resources.ResourceManager.
            //card[] res = engine.ReadStream(Properties.Resources.ResourceManager.GetStream("Database").BeginRead()) as card[];
            //var reader = new StreamReader();
            

            card holder = null;
            //card[] res = engine.ReadFile("C:\\Users\\shalafein\\Documents\\Visual Studio 2013\\Projects\\HearthDrawFree\\HearthDrawFree\\Resources\\Database.txt") as card[];
            //foreach (card cards in res)
            //{
            while (!_databaseReader.EndOfStream)
            {
                var line = _databaseReader.ReadLine();
                var values = line.Split(',');
                holder = new card(Convert.ToInt32(values[0]), values[1].ToString(), values[2].ToString());
                cardSelect.Items.Add(holder);
            }
            //}
            //cardBox.Items.RemoveAt(0);
            cardSelect.DisplayMember = "myName";
            drawnBox.Items.Clear();
            cardBox.DisplayMember = "myName";
            drawnBox.DisplayMember = "myName";
            deckBox.DisplayMember = "myName";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (cardSelect.SelectedItem != null)
            {
                cardBox.Items.Add(cardSelect.SelectedItem);
            }
        }

        private void cardBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cardBox.SelectedItem != null)
            {
                drawnBox.Items.Add(cardBox.SelectedItem);
                cardBox.Items.RemoveAt(cardBox.Items.IndexOf(cardBox.SelectedItem));
            }
        }

        private void drawnBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (drawnBox.SelectedItem != null)
            {
                cardBox.Items.Add(drawnBox.SelectedItem);
                drawnBox.Items.RemoveAt(drawnBox.Items.IndexOf(drawnBox.SelectedItem));
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drawnBox.Items.Count; i++)
            {
                drawnBox.SetSelected(i, true);
                cardBox.Items.Add(drawnBox.SelectedItem);
            }
            drawnBox.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "")
            {
                if (nameBox.Text.ToLower() == "clear")
                {
                    cardBox.Items.Clear();
                    drawnBox.Items.Clear();
                }
                else
                {
                    List<card> fdeck = new List<card>();
                    card holder = null;
                    for (int i = 0; i < cardBox.Items.Count; i++)
                    {
                        holder = (card)cardBox.Items[i];
                        fdeck.Add(holder);
                    }
                    for (int i = 0; i < drawnBox.Items.Count; i++)
                    {
                        holder = (card)drawnBox.Items[i];
                        fdeck.Add(holder);
                    }
                    Deck deckHolder = new Deck(fdeck, nameBox.Text);
                    decks.Add(deckHolder);
                    deckBox.Items.Add(nameBox.Text);
                }
            }
            nameBox.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (deckBox.SelectedItem != null)
            {
                cardBox.Items.Clear();
                drawnBox.Items.Clear();
                for (int i = 0; i < decks.ElementAt(deckBox.Items.IndexOf(deckBox.SelectedItem)).numCards(); i++)
                {
                    cardBox.Items.Add(decks.ElementAt(deckBox.Items.IndexOf(deckBox.SelectedItem)).getCard(i));
                }
            }
        }

        private void HearthDrawFree_Load(object sender, EventArgs e)
        {
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _databaseReader = new StreamReader(_assembly.GetManifestResourceStream("HearthDrawFree.Resources.Database.txt"));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            GrabCards();
        }
    }
}
