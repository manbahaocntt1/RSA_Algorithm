using RSA_Algorithm;
using System.Numerics;

namespace RSAForm
{
    public partial class Form1 : Form
    {
        BigInteger p;
        BigInteger q;
        BigInteger b;

        public Form1()
        {
            InitializeComponent();
            p = RSA_Algorithm.Program.GeneratePrimeNumber();
            q = RSA_Algorithm.Program.GeneratePrimeNumber();
            b = RSA_Algorithm.Program.ChoosePublicKey((p - 1) * (q - 1));
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtBanRo1.Text);

            BigInteger n = BigInteger.Multiply(p, q);

            string encryptedText = RSA_Algorithm.Program.RsaEncrypt(txtBanRo1.Text, b, n);
            txtBanMa1.Text = encryptedText;

        }

        private void txtBanMa2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            txtBanMa2.Text = txtBanMa1.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Save the encrypted text to a file
            string encryptedText = txtBanMa1.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Encrypted Text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(filePath, encryptedText);
                    MessageBox.Show("Text saved successfully.", "Save Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the text: " + ex.Message, "Save Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {


            BigInteger n = BigInteger.Multiply(p, q);

            BigInteger a = RSA_Algorithm.Program.CalculatePrivateKey(b, (p - 1) * (q - 1));
            string decryptedText = RSA_Algorithm.Program.RsaDecrypt(txtBanMa2.Text, a, n);
            txtBanRo2.Text = decryptedText;

        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            // Save the encrypted text to a file
            string encryptedText = txtBanRo2.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Encrypted Text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(filePath, encryptedText);
                    MessageBox.Show("Text saved successfully.", "Save Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the text: " + ex.Message, "Save Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFileBanRo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    // Display the file content or perform further processing
                    // For example, you can assign it to a text box:
                    txtBanRo1.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the file: " + ex.Message, "Open Text File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    // Display the file content or perform further processing
                    // For example, you can assign it to a text box:
                    txtBanMa2.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading the file: " + ex.Message, "Open Text File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}