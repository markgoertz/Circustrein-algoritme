using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein_algoritme
{
    public partial class Form1 : Form
    {
        private readonly List<Animal> Animals = new List<Animal>();
        private readonly Train train = new Train();

        public Form1()
        {
            InitializeComponent();
        }

        private void Wagonlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWagon = Wagonlist.SelectedIndex;
            List<Animal> AnimalInWagon = train.AnimalWagons[selectedWagon].Animals;
            string toDisplay = string.Join(Environment.NewLine, AnimalInWagon);
            MessageBox.Show(toDisplay);
        }

        private void AddAnimalbtn_Click(object sender, EventArgs e)
        {
            Animal.Sizes size;
            bool isCarnivore = carnivoreRbtn.Checked;

            if (!carnivoreRbtn.Checked && !herbivoreRbtn.Checked || !bigRbtn.Checked && !mediumRbtn.Checked && !smallRbtn.Checked)
            {
                MessageBox.Show("Please select values to add animals to the system.");
            }
            else
            {
                if (smallRbtn.Checked)
                {
                    size = Animal.Sizes.small;
                }
                else if (mediumRbtn.Checked)
                {
                    size = Animal.Sizes.medium;
                }
                else
                {
                    size = Animal.Sizes.large;
                }

                Animal animals = new Animal(size, isCarnivore);
                Animals.Add(animals);
                
                Animallist.Items.Add(animals);
            }
        }

        private void Orginisebtn_Click(object sender, EventArgs e)
        {
            
            train.FillWagon(Animals);
            Wagonlist.Items.Clear();
            foreach (Wagon selectedWagon in train.AnimalWagons)
            {
                Wagonlist.Items.Add(selectedWagon);
            }
        }
    }
}
