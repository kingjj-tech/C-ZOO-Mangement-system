using System;
using System.Windows.Forms;

namespace Zoo_management_System
{
    public partial class Form1 : Form
    {
        private ZooManager zooManager = new ZooManager();

        public Form1()
        {
            InitializeComponent();

           
            // Populate comboBox1 with AnimalType enum values
            comboBox1.DataSource = Enum.GetValues(typeof(AnimalType));

            // Populate comboBoxHabitat with HabitatType enum values
            comboBoxHabitat.DataSource = Enum.GetValues(typeof(HabitatType));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial load tasks if any
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from form controls
            string animalName = textBox1.Text;
            int animalAge = (int)numericUpDown1.Value;
            double animalWeight = (double)numericUpDown2.Value;
            AnimalType animalType = (AnimalType)comboBox1.SelectedItem;
            HabitatType habitatType = (HabitatType)comboBoxHabitat.SelectedItem;
            string speakSound = textBox2.Text;

            // Create a new animal based on selected type
            Animal animal = animalType switch
            {
                AnimalType.Mammal => new Lion { Name = animalName, Age = animalAge, Weight = animalWeight, Habitat = habitatType, SpeakSound = speakSound },
                AnimalType.Bird => new Parrot { Name = animalName, Age = animalAge, Weight = animalWeight, Habitat = habitatType, SpeakSound = speakSound },
                AnimalType.Reptile => new Monkey { Name = animalName, Age = animalAge, Weight = animalWeight, Habitat = habitatType, SpeakSound = speakSound },
                AnimalType.Fish => new Gorilla { Name = animalName, Age = animalAge, Weight = animalWeight, Habitat = habitatType, SpeakSound = speakSound },
                _ => throw new ArgumentOutOfRangeException()
            };

            // Add the animal to the zoo
            zooManager.AddAnimal(animal);

            // Show success message
            MessageBox.Show($"{animalName} has been added to the zoo!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Update the ListBox with the new animal
            listBox1.Items.Add(animal.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open AnimalsView form and pass the ZooManager instance
            AnimalsView animalsView = new AnimalsView(zooManager);
            animalsView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show animals in the ListBox
            listBox1.Items.Clear();
            foreach (var animal in zooManager.GetAnimals())
            {
                listBox1.Items.Add(animal.Name);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save animals when the form is closing
            zooManager.SaveAnimals();
        }
    }
}
