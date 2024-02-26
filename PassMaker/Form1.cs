using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PassMaker
{
    public partial class Form1 : Form
    {
        private StringBuilder passwordPartial = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            // -Sub
            btnPassParcial.Click -= new EventHandler(btnPassParcial_Click);
            // +Event Handler
            btnPassParcial.Click += new EventHandler(btnPassParcial_Click);
        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassParcial_TextChanged(object sender, EventArgs e)
        {
            passwordPartial.Clear();
            passwordPartial.Append(txtPassParcial.Text);
            UpdatePasswordBox();
        }

        private void btnGerarPassword_Click(object sender, EventArgs e)
        {
            int comprimento = Convert.ToInt32(nudComprimento.Value);
            bool usarCaracteresEspeciais = chkCaracteresEspeciais.Checked;
            bool evitarAmbiguos = chkEvitarAmbiguos.Checked;

            comprimento = Math.Min(comprimento, 35);

            string generatedPassword = GeneratePassword(comprimento, usarCaracteresEspeciais, evitarAmbiguos);

            txtPassGerada.Text = generatedPassword;

            passwordPartial.Clear();
            UpdatePasswordBox();
            GenerateAndDisplayPassword();
        }

        private void btnLimparPassword_Click(object sender, EventArgs e)
        {
            passwordPartial.Clear();
            UpdatePasswordBox();
        }

        private void btnPassParcial_Click(object sender, EventArgs e)
        {
            string parcialPassword = txtPassParcial.Text;

            if (!string.IsNullOrEmpty(parcialPassword))
            {
                passwordPartial.Clear();

                passwordPartial.Append(parcialPassword);

                GenerateAndDisplayPassword();
            }
            else
            {
                MessageBox.Show("Por favor introduza dados para gerar uma Password com os mesmos.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerateAndDisplayPassword()
        {
            int maxPasswordLength = Convert.ToInt32(nudComprimento.Value);
            bool usarCaracteresEspeciais = chkCaracteresEspeciais.Checked;
            bool evitarAmbiguos = chkEvitarAmbiguos.Checked;

            int remainingSpace = maxPasswordLength - passwordPartial.Length;
            int adjustedLength = Math.Min(remainingSpace, maxPasswordLength);

            string generatedPassword = GeneratePassword(adjustedLength, usarCaracteresEspeciais, evitarAmbiguos);

            txtPassGerada.Text = generatedPassword;
        }

        private void UpdatePasswordBox()
        {
            txtPassParcial.Text = passwordPartial.ToString();
        }

        private string GeneratePassword(int length, bool useSpecialChars, bool avoidAmbiguous)
        {
            const string lowercaseChars = "abcdefghijkmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string numbers = "123456789";
            const string symbols = "!@#$%^&*()-_+=<>?";

            StringBuilder chars = new StringBuilder(lowercaseChars);

            if (chkNumeros.Checked) chars.Append(numbers);
            if (chkMaiusculas.Checked) chars.Append(uppercaseChars);
            if (useSpecialChars) chars.Append(symbols);
            if (avoidAmbiguous) chars.Replace("l", "").Replace("I", "");

            char[] passwordArray = new char[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                int count = chars.Length;
                byte[] uint32Buffer = new byte[sizeof(uint)];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(uint32Buffer);
                    uint num = BitConverter.ToUInt32(uint32Buffer, 0);

                    passwordArray[i] = chars[(int)(num % (uint)count)];
                }
            }

            int insertIndex = new Random().Next(0, length);
            StringBuilder finalPassword = new StringBuilder(new string(passwordArray));
            finalPassword.Insert(insertIndex, passwordPartial.ToString());

            return finalPassword.ToString();
        }

        private void btnCopiaPassword_Click(object sender, EventArgs e)
        {
            string mainPassword = txtPassGerada.Text;

            if (!string.IsNullOrEmpty(mainPassword))
            {
                Clipboard.SetText(mainPassword);
                MessageBox.Show("Password copiada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma password para copiar!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}