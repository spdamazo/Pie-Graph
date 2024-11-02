namespace PieGraph
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pieChartControl1 = new PieChartControl();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtLabel = new TextBox();
            btnAdd = new Button();
            txtValue = new TextBox();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            dataGridView1 = new DataGridView();
            Label = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            btnGenerateChart = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pieChartControl1
            // 
            pieChartControl1.Labels = (List<string>)resources.GetObject("pieChartControl1.Labels");
            pieChartControl1.Location = new Point(27, 29);
            pieChartControl1.Name = "pieChartControl1";
            pieChartControl1.Size = new Size(584, 670);
            pieChartControl1.TabIndex = 0;
            pieChartControl1.Values = (List<float>)resources.GetObject("pieChartControl1.Values");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLabel);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Location = new Point(638, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 210);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 92);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 4;
            label2.Text = "Value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 3;
            label1.Text = "Label:";
            // 
            // txtLabel
            // 
            txtLabel.Location = new Point(99, 44);
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(283, 31);
            txtLabel.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(269, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(98, 92);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(283, 31);
            txtValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnGenerateChart);
            groupBox2.Location = new Point(638, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 405);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "List of Values";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(152, 339);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Label, Value });
            dataGridView1.Location = new Point(16, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(365, 277);
            dataGridView1.TabIndex = 3;
            // 
            // Label
            // 
            Label.HeaderText = "Label";
            Label.MinimumWidth = 8;
            Label.Name = "Label";
            Label.ReadOnly = true;
            Label.Width = 150;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.ReadOnly = true;
            Value.Width = 150;
            // 
            // btnGenerateChart
            // 
            btnGenerateChart.Location = new Point(270, 339);
            btnGenerateChart.Name = "btnGenerateChart";
            btnGenerateChart.Size = new Size(112, 34);
            btnGenerateChart.TabIndex = 0;
            btnGenerateChart.Text = "Generate";
            btnGenerateChart.UseVisualStyleBackColor = true;
            btnGenerateChart.Click += btnGenerateChart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 729);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pieChartControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Pie Graph";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PieChartControl pieChartControl1;
        private GroupBox groupBox1;
        private TextBox txtValue;
        private GroupBox groupBox2;
        private Button btnAdd;
        private Button btnGenerateChart;
        private TextBox txtLabel;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn Value;
        private Button btnReset;
    }
}
