namespace MatrixCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMatrix1 = new System.Windows.Forms.TextBox();
            this.txtMatrix2 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.ComboOperations = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtMatrix1
            this.txtMatrix1.Location = new System.Drawing.Point(12, 12);
            this.txtMatrix1.Multiline = true;
            this.txtMatrix1.Size = new System.Drawing.Size(260, 60);

            // txtMatrix2
            this.txtMatrix2.Location = new System.Drawing.Point(12, 80);
            this.txtMatrix2.Multiline = true;
            this.txtMatrix2.Size = new System.Drawing.Size(260, 60);

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(12, 200);
            this.buttonCalculate.Size = new System.Drawing.Size(120, 30);
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // buttonSave
            this.buttonSave.Location = new System.Drawing.Point(150, 200);
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.Text = "Save to File";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // ComboOperations
            this.ComboOperations.Location = new System.Drawing.Point(12, 240);
            this.ComboOperations.Size = new System.Drawing.Size(260, 30);
            this.ComboOperations.Items.AddRange(new object[] { "Multiplication", "Determinant" });
            this.ComboOperations.SelectedIndex = 0;

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(12, 280);
            this.lblResult.Size = new System.Drawing.Size(260, 60);
            this.lblResult.Text = "Result";

            // lblInstructions
            this.lblInstructions.Location = new System.Drawing.Point(12, 350);
            this.lblInstructions.Size = new System.Drawing.Size(260, 40);
            this.lblInstructions.Text = "Enter matrices like:\n1 2; 3 4 (Each row separated by ';')";
            this.Controls.Add(this.lblInstructions);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.Controls.Add(this.txtMatrix1);
            this.Controls.Add(this.txtMatrix2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ComboOperations);
            this.Controls.Add(this.lblInstructions);
            this.Text = "Matrix Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMatrix1;
        private System.Windows.Forms.TextBox txtMatrix2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox ComboOperations;
        private System.Windows.Forms.Label lblInstructions;
    }
}