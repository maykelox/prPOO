namespace prPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Chizu";
            perrito.Raza = "BullDog";
            perrito.Altura = "0.40";

            txtResultado.Text = perrito.comer("Carne");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Lazii";
            perrito.Altura = "0.80";

            txtResultado.Text = perrito.comer("Pollo");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            perro perrito = new perro("Peluche", "0.90", "BullDocer");
            txtResultado.Text = perrito.comer("Pan");

        }
    }
}