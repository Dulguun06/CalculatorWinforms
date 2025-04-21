namespace CalculatorWinForms.Views
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDisplay = new Panel();
            resultTextBox = new TextBox();
            panelButtons = new Panel();
            tableButtons = new TableLayoutPanel();
            panel1 = new Panel();
            btnMC = new Button();
            btnMMinus = new Button();
            btnMPlus = new Button();
            memoryList = new ListView();
            memory = new ColumnHeader();
            panelDisplay.SuspendLayout();
            panelButtons.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = Color.FromArgb(31, 32, 39);
            panelDisplay.Controls.Add(resultTextBox);
            panelDisplay.ForeColor = Color.FromArgb(167, 178, 255);
            panelDisplay.Location = new Point(0, 0);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(400, 100);
            panelDisplay.TabIndex = 0;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.FromArgb(31, 32, 39);
            resultTextBox.Font = new Font("Montserrat Medium", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultTextBox.ForeColor = Color.FromArgb(167, 178, 255);
            resultTextBox.Location = new Point(0, 5);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.RightToLeft = RightToLeft.No;
            resultTextBox.Size = new Size(400, 89);
            resultTextBox.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelButtons.BackColor = Color.PowderBlue;
            panelButtons.Controls.Add(tableButtons);
            panelButtons.Location = new Point(0, 100);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(400, 270);
            panelButtons.TabIndex = 2;
            // 
            // tableButtons
            // 
            tableButtons.BackColor = Color.FromArgb(41, 43, 55);
            tableButtons.ColumnCount = 4;
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableButtons.Dock = DockStyle.Fill;
            tableButtons.ForeColor = Color.FromArgb(167, 178, 255);
            tableButtons.Location = new Point(0, 0);
            tableButtons.Name = "tableButtons";
            tableButtons.RowCount = 4;
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableButtons.Size = new Size(400, 270);
            tableButtons.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(43, 45, 53);
            panel1.Controls.Add(btnMC);
            panel1.Controls.Add(btnMMinus);
            panel1.Controls.Add(btnMPlus);
            panel1.Controls.Add(memoryList);
            panel1.Location = new Point(400, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 370);
            panel1.TabIndex = 3;
            // 
            // btnMC
            // 
            btnMC.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMC.BackColor = Color.FromArgb(43, 45, 53);
            btnMC.FlatStyle = FlatStyle.Popup;
            btnMC.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMC.ForeColor = Color.FromArgb(167, 178, 255);
            btnMC.Location = new Point(118, 47);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(42, 29);
            btnMC.TabIndex = 3;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            // 
            // btnMMinus
            // 
            btnMMinus.BackColor = Color.FromArgb(43, 45, 53);
            btnMMinus.FlatStyle = FlatStyle.Popup;
            btnMMinus.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMMinus.ForeColor = Color.FromArgb(167, 178, 255);
            btnMMinus.Location = new Point(70, 47);
            btnMMinus.Name = "btnMMinus";
            btnMMinus.Size = new Size(42, 29);
            btnMMinus.TabIndex = 2;
            btnMMinus.Text = "M-";
            btnMMinus.UseVisualStyleBackColor = false;
            // 
            // btnMPlus
            // 
            btnMPlus.BackColor = Color.FromArgb(43, 45, 53);
            btnMPlus.FlatStyle = FlatStyle.Popup;
            btnMPlus.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMPlus.ForeColor = Color.FromArgb(167, 178, 255);
            btnMPlus.Location = new Point(16, 47);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(48, 29);
            btnMPlus.TabIndex = 1;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = false;
            btnMPlus.Click += CalculatorButton_Click;
            // 
            // memoryList
            // 
            memoryList.BackColor = Color.FromArgb(31, 32, 39);
            memoryList.Columns.AddRange(new ColumnHeader[] { memory });
            memoryList.ForeColor = Color.White;
            memoryList.FullRowSelect = true;
            memoryList.Location = new Point(0, 0);
            memoryList.Name = "memoryList";
            memoryList.Size = new Size(250, 370);
            memoryList.TabIndex = 0;
            memoryList.UseCompatibleStateImageBehavior = false;
            memoryList.View = View.Details;
            // 
            // memory
            // 
            memory.Text = "Memory";
            memory.Width = 250;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43,45,55);
            ClientSize = new Size(651, 372);
            Controls.Add(panel1);
            Controls.Add(panelButtons);
            Controls.Add(panelDisplay);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            panelButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDisplay;
        private Panel panelButtons;
        private Panel panel1;
        private TextBox resultTextBox;
        private TableLayoutPanel tableButtons;
        private ListView memoryList;
        private ColumnHeader memory;
        private Button btnMMinus;
        private Button btnMPlus;
        private Button btnMC;
    }
}