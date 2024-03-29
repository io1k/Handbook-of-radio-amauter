
namespace Handbook_of_radio_amauter
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
            btSearch = new Button();
            combDetailType = new ComboBox();
            lbTypeName = new Label();
            combTransistorType = new ComboBox();
            tbVoltage = new TextBox();
            tbCurrent = new TextBox();
            lbTransistorType = new Label();
            lbVoltage = new Label();
            lbCurrent = new Label();
            SuspendLayout();
            // 
            // btSearch
            // 
            btSearch.Location = new Point(64, 390);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 0;
            btSearch.Text = "Пошук";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // combDetailType
            // 
            combDetailType.FormattingEnabled = true;
            combDetailType.Items.AddRange(new object[] { "Транзистор" });
            combDetailType.Location = new Point(61, 110);
            combDetailType.Name = "combDetailType";
            combDetailType.Size = new Size(151, 28);
            combDetailType.TabIndex = 1;
            // 
            // lbTypeName
            // 
            lbTypeName.Location = new Point(0, 0);
            lbTypeName.Name = "lbTypeName";
            lbTypeName.Size = new Size(100, 23);
            lbTypeName.TabIndex = 10;
            // 
            // combTransistorType
            // 
            combTransistorType.FormattingEnabled = true;
            combTransistorType.Items.AddRange(new object[] { "Біполярный", "Польовий" });
            combTransistorType.Location = new Point(61, 189);
            combTransistorType.Name = "combTransistorType";
            combTransistorType.Size = new Size(151, 28);
            combTransistorType.TabIndex = 3;
            // 
            // tbVoltage
            // 
            tbVoltage.Location = new Point(61, 268);
            tbVoltage.Name = "tbVoltage";
            tbVoltage.Size = new Size(125, 27);
            tbVoltage.TabIndex = 4;
            // 
            // tbCurrent
            // 
            tbCurrent.Location = new Point(61, 347);
            tbCurrent.Name = "tbCurrent";
            tbCurrent.Size = new Size(125, 27);
            tbCurrent.TabIndex = 5;
            tbCurrent.TextChanged += tbCurrent_TextChanged;
            // 
            // lbTransistorType
            // 
            lbTransistorType.AutoSize = true;
            lbTransistorType.Location = new Point(59, 156);
            lbTransistorType.Name = "lbTransistorType";
            lbTransistorType.Size = new Size(190, 20);
            lbTransistorType.TabIndex = 6;
            lbTransistorType.Text = "Виберіть тип транзистора";
            // 
            // lbVoltage
            // 
            lbVoltage.AutoSize = true;
            lbVoltage.Location = new Point(59, 235);
            lbVoltage.Name = "lbVoltage";
            lbVoltage.Size = new Size(122, 20);
            lbVoltage.TabIndex = 7;
            lbVoltage.Text = "Бажана напруга";
            // 
            // lbCurrent
            // 
            lbCurrent.AutoSize = true;
            lbCurrent.Location = new Point(61, 310);
            lbCurrent.Name = "lbCurrent";
            lbCurrent.Size = new Size(184, 20);
            lbCurrent.TabIndex = 8;
            lbCurrent.Text = "Бажана поточна напруга";
            lbCurrent.Click += lbCurrent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 492);
            Controls.Add(lbCurrent);
            Controls.Add(lbVoltage);
            Controls.Add(lbTransistorType);
            Controls.Add(tbCurrent);
            Controls.Add(tbVoltage);
            Controls.Add(combTransistorType);
            Controls.Add(lbTypeName);
            Controls.Add(combDetailType);
            Controls.Add(btSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btSearch;
        private ComboBox combDetailType;
        private Label lbTypeName;
        private ComboBox combTransistorType;
        private TextBox tbVoltage;
        private TextBox tbCurrent;
        private Label lbTransistorType;
        private Label lbVoltage;
        private Label lbCurrent;
    }
}
