namespace Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pclient.Visible = true;
            pchambre.Visible = false;
            preserv.Visible = false;
            pclient.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pclient.Visible = true;
            preserv.Visible = true;
            pchambre.Visible = false;
            preserv.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pclient.Visible = true;
            preserv.Visible =true;
            pchambre.Visible = true;
            pchambre.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pclient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Veuillez Selectionner Un ligne");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < this.dataGridView2.Rows.Count - 1; i++)
            {


                if (this.dataGridView2.Rows[i].Cells[0].Value.ToString() == this.box6.Text)
                {
                    this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    MessageBox.Show("Ce Produit Est Exist");
                    cont = 1;
                    break;
                }
            }
            if (cont == 0)
            {
                MessageBox.Show("Ce Produit N'existe Pas");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pchambre.Visible = false;
            pclient.Visible = false;
            preserv.Visible = false;
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("4 Etoile");
            comboBox1.Items.Add("5 Etoile");
        }

        private void pchambre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void preserv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pchambre.Visible = false;
            preserv.Visible = false;
            pclient.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pchambre_Paint_1(object sender, PaintEventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double res;
            if (radioButton1.Checked)
            {
                res = 0;
            }
            else
            {
                res = 500;
            }
            try
            {
                int nb = int.Parse(textBox1.Text);
                double prix;
                if (comboBox1.SelectedIndex == 0)
                {
                    prix = 600 * nb + res;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    prix = 800 * nb + res;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    prix = 1100 * nb + res;
                }
                else
                {
                    MessageBox.Show("Verifier Votre Choix");
                    prix = 0;
                }
                textBox2.Text = prix.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifier Votre Choix");
            }
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (box1.Text == "" || box2.Text == "" || box3.Text == "" || box4.Text == "" || box5.Text == "")
                {
                    MessageBox.Show("Veuillez Saisir Tout Les Champs");
                }
                else
                {
                    string id = box1.Text;
                    string nom = box2.Text;
                    string pre = box3.Text;
                    string cin = box4.Text;
                    string mobile = box5.Text;
                    this.dataGridView2.Rows.Add(id, nom, pre, cin, mobile);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez Verifier Vorte Requete");
            }
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
            
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Veuillez Selectionner Un ligne");
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (box7.Text == "" || box8.Text == "" || box9.Text == "" || box10.Text == "" || box11.Text == "")
                {
                    MessageBox.Show("Veuillez Saisir Tout Les Champs");
                }
                else
                {
                    string id = box7.Text;
                    string nom = box8.Text;
                    string pre = box9.Text;
                    string cin = box10.Text;
                    string mobile = box11.Text;
                    this.dataGridView1.Rows.Add(id, nom, pre, cin, mobile);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez Verifier Vorte Requete");
            }
            box7.Clear();
            box8.Clear();
            box9.Clear();
            box10.Clear();
            box11.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            box7.Clear();
            box8.Clear();
            box9.Clear();
            box10.Clear();
            box11.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Veuillez Selectionner Un ligne");
            }
        }
    }
}