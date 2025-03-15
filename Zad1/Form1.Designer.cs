namespace Zad1
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
            Dzielna = new TextBox();
            Dzielnik = new TextBox();
            Wynik = new TextBox();
            buttonOblicz = new Button();
            buttonWyczyść = new Button();
            SuspendLayout();
            // 
            // Dzielna
            // 
            Dzielna.AccessibleName = "";
            Dzielna.Location = new Point(12, 12);
            Dzielna.Name = "Dzielna";
            Dzielna.PlaceholderText = "Dzielna";
            Dzielna.Size = new Size(262, 23);
            Dzielna.TabIndex = 0;
            // 
            // Dzielnik
            // 
            Dzielnik.Location = new Point(12, 41);
            Dzielnik.Name = "Dzielnik";
            Dzielnik.PlaceholderText = "Dzielnik";
            Dzielnik.Size = new Size(262, 23);
            Dzielnik.TabIndex = 1;
            // 
            // Wynik
            // 
            Wynik.Enabled = false;
            Wynik.Location = new Point(12, 100);
            Wynik.Name = "Wynik";
            Wynik.PlaceholderText = "Wynik";
            Wynik.ReadOnly = true;
            Wynik.Size = new Size(262, 23);
            Wynik.TabIndex = 2;
            // 
            // buttonOblicz
            // 
            buttonOblicz.Location = new Point(59, 132);
            buttonOblicz.Name = "buttonOblicz";
            buttonOblicz.Size = new Size(75, 23);
            buttonOblicz.TabIndex = 3;
            buttonOblicz.Text = "Oblicz";
            buttonOblicz.UseVisualStyleBackColor = true;
            buttonOblicz.Click += ButtonOblicz_Click;
            // 
            // buttonWyczyść
            // 
            buttonWyczyść.Location = new Point(156, 132);
            buttonWyczyść.Name = "buttonWyczyść";
            buttonWyczyść.Size = new Size(75, 23);
            buttonWyczyść.TabIndex = 4;
            buttonWyczyść.Text = "Wyczyść";
            buttonWyczyść.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 204);
            Controls.Add(buttonWyczyść);
            Controls.Add(buttonOblicz);
            Controls.Add(Wynik);
            Controls.Add(Dzielnik);
            Controls.Add(Dzielna);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Dzielna;
        private TextBox Dzielnik;
        private TextBox Wynik;
        private Button buttonOblicz;
        private Button buttonWyczyść;
    }
}
