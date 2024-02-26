namespace PassMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nudComprimento = new NumericUpDown();
            chkCaracteresEspeciais = new CheckBox();
            chkEvitarAmbiguos = new CheckBox();
            chkNumeros = new CheckBox();
            chkMaiusculas = new CheckBox();
            txtPassParcial = new TextBox();
            txtPassGerada = new TextBox();
            btnGerarPass = new Button();
            btnCopiaPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnPassParcial = new Button();
            ((System.ComponentModel.ISupportInitialize)nudComprimento).BeginInit();
            SuspendLayout();
            // 
            // nudComprimento
            // 
            resources.ApplyResources(nudComprimento, "nudComprimento");
            nudComprimento.Name = "nudComprimento";
            nudComprimento.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // chkCaracteresEspeciais
            // 
            resources.ApplyResources(chkCaracteresEspeciais, "chkCaracteresEspeciais");
            chkCaracteresEspeciais.ForeColor = SystemColors.ButtonHighlight;
            chkCaracteresEspeciais.Name = "chkCaracteresEspeciais";
            chkCaracteresEspeciais.UseVisualStyleBackColor = true;
            // 
            // chkEvitarAmbiguos
            // 
            resources.ApplyResources(chkEvitarAmbiguos, "chkEvitarAmbiguos");
            chkEvitarAmbiguos.ForeColor = SystemColors.ButtonHighlight;
            chkEvitarAmbiguos.Name = "chkEvitarAmbiguos";
            chkEvitarAmbiguos.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            resources.ApplyResources(chkNumeros, "chkNumeros");
            chkNumeros.ForeColor = SystemColors.ButtonHighlight;
            chkNumeros.Name = "chkNumeros";
            chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkMaiusculas
            // 
            resources.ApplyResources(chkMaiusculas, "chkMaiusculas");
            chkMaiusculas.ForeColor = SystemColors.ButtonHighlight;
            chkMaiusculas.Name = "chkMaiusculas";
            chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // txtPassParcial
            // 
            resources.ApplyResources(txtPassParcial, "txtPassParcial");
            txtPassParcial.Name = "txtPassParcial";
            // 
            // txtPassGerada
            // 
            resources.ApplyResources(txtPassGerada, "txtPassGerada");
            txtPassGerada.Name = "txtPassGerada";
            txtPassGerada.ReadOnly = true;
            txtPassGerada.TextChanged += txtPassParcial_TextChanged;
            // 
            // btnGerarPass
            // 
            resources.ApplyResources(btnGerarPass, "btnGerarPass");
            btnGerarPass.Name = "btnGerarPass";
            btnGerarPass.UseVisualStyleBackColor = true;
            btnGerarPass.Click += btnGerarPassword_Click;
            // 
            // btnCopiaPassword
            // 
            resources.ApplyResources(btnCopiaPassword, "btnCopiaPassword");
            btnCopiaPassword.Name = "btnCopiaPassword";
            btnCopiaPassword.UseVisualStyleBackColor = true;
            btnCopiaPassword.Click += btnCopiaPassword_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Name = "label3";
            // 
            // btnPassParcial
            // 
            resources.ApplyResources(btnPassParcial, "btnPassParcial");
            btnPassParcial.Name = "btnPassParcial";
            btnPassParcial.UseVisualStyleBackColor = true;
            btnPassParcial.Click += btnPassParcial_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(btnPassParcial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCopiaPassword);
            Controls.Add(btnGerarPass);
            Controls.Add(txtPassGerada);
            Controls.Add(txtPassParcial);
            Controls.Add(chkMaiusculas);
            Controls.Add(chkNumeros);
            Controls.Add(chkEvitarAmbiguos);
            Controls.Add(chkCaracteresEspeciais);
            Controls.Add(nudComprimento);
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudComprimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudComprimento;
        private CheckBox chkCaracteresEspeciais;
        private CheckBox chkEvitarAmbiguos;
        private CheckBox chkNumeros;
        private CheckBox chkMaiusculas;
        private TextBox txtPassParcial;
        private TextBox txtPassGerada;
        private Button btnGerarPass;
        private Button btnCopiaPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPassParcial;
    }
}
