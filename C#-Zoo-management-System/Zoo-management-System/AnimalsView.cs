using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_management_System
{
    public partial class AnimalsView : Form
    {
        private ZooManager zooManager;

        internal AnimalsView(ZooManager zooManager)
        {
            InitializeComponent();
            this.zooManager = zooManager;
            DisplayAnimals();

            // Add event handlers
            button1.Click += Button1_Click; // Back button
            button5.Click += Button5_Click; // Sleep button
            button2.Click += Button2_Click; // Speak button
            button4.Click += Button4_Click; // Feed button
            button3.Click += Button3_Click; // Move button
            button6.Click += Button6_Click; // Remove Animal button
        }

        private void DisplayAnimals()
        {
            listBox1.Items.Clear();
            foreach (var animal in zooManager.GetAnimals())
            {
                string animalType = GetAnimalType(animal);
                listBox1.Items.Add($"{animal.Name} (Type: {animalType}) - Age: {animal.Age}, Weight: {animal.Weight}, Habitat: {animal.Habitat}");
            }
        }

        private string GetAnimalType(Animal animal)
        {
            if (animal is Lion || animal is Gorilla)
            {
                return "Mammal";
            }
            else if (animal is Parrot)
            {
                return "Bird";
            }
            else if (animal is Fish)
            {
                return "Fish";
            }
            else if (animal is Monkey)
            {
                return "reptile";
            }
            return "Unknown";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = listBox1.SelectedItem.ToString();
                MessageBox.Show($"{selectedAnimal} is now sleeping.", "Animal Sleep", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = GetSelectedAnimalName();
                var animal = zooManager.GetAnimalByName(selectedAnimal);

                if (animal != null)
                {
                    MessageBox.Show(animal.SpeakSound, "Animal Speak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = GetSelectedAnimalName();
                var animal = zooManager.GetAnimalByName(selectedAnimal);

                if (animal != null && animal is IFeedable feedable)
                {
                    Food food = GetFoodForAnimal(animal);
                    feedable.Feed(food);
                    MessageBox.Show($"{animal.Name} is eating {food.FoodType}.", "Animal Feed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = GetSelectedAnimalName();
                var animal = zooManager.GetAnimalByName(selectedAnimal);

                if (animal != null)
                {
                    if (animal is Fish)
                    {
                        MessageBox.Show($"{animal.Name} is swimming.", "Animal Move", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (animal is IMovable movable)
                    {
                        movable.Move();
                        MessageBox.Show($"{animal.Name} is moving.", "Animal Move", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = GetSelectedAnimalName();
                zooManager.RemoveAnimal(selectedAnimal);
                DisplayAnimals();
                MessageBox.Show($"{selectedAnimal} has been removed from the zoo.", "Animal Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetSelectedAnimalName()
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAnimal = listBox1.SelectedItem.ToString();
                // Assuming the format is: "Name (Type: AnimalType) - Age: Age, Weight: Weight, Habitat: Habitat"
                // Extract the name before the first space.
                return selectedAnimal.Split(' ')[0];
            }
            return null;
        }

        private Food GetFoodForAnimal(Animal animal)
        {
            if (animal is Lion)
            {
                return new Food { FoodType = FoodTypeEnum.Meat };
            }
            else if (animal is Parrot)
            {
                return new Food { FoodType = FoodTypeEnum.Seeds };
            }
            else if (animal is Monkey || animal is Gorilla)
            {
                return new Food { FoodType = FoodTypeEnum.Fruits };
            }
            else
            {
                return new Food { FoodType = FoodTypeEnum.Vegetables };
            }
        }

        private void AnimalsView_Load(object sender, EventArgs e)
        {
        }
    }
}

