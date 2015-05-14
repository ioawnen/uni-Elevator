namespace ElevatorR2
{
    partial class debug
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debug));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liftPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevatorDBDataSet = new ElevatorR2.ElevatorDBDataSet();
            this.operationsLogTableAdapter = new ElevatorR2.ElevatorDBDataSetTableAdapters.OperationsLogTableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            this.programOutputLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(386, 546);
            this.textBox1.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(12, 577);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.liftPositionDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationsLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(404, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(620, 546);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 75;
            // 
            // liftPositionDataGridViewTextBoxColumn
            // 
            this.liftPositionDataGridViewTextBoxColumn.DataPropertyName = "LiftPosition";
            this.liftPositionDataGridViewTextBoxColumn.FillWeight = 35F;
            this.liftPositionDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.liftPositionDataGridViewTextBoxColumn.Name = "liftPositionDataGridViewTextBoxColumn";
            this.liftPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.liftPositionDataGridViewTextBoxColumn.Width = 50;
            // 
            // eventDescriptionDataGridViewTextBoxColumn
            // 
            this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
            this.eventDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventDescriptionDataGridViewTextBoxColumn.Width = 347;
            // 
            // operationsLogBindingSource
            // 
            this.operationsLogBindingSource.DataMember = "OperationsLog";
            this.operationsLogBindingSource.DataSource = this.elevatorDBDataSet;
            // 
            // elevatorDBDataSet
            // 
            this.elevatorDBDataSet.DataSetName = "ElevatorDBDataSet";
            this.elevatorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationsLogTableAdapter
            // 
            this.operationsLogTableAdapter.ClearBeforeFill = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(942, 577);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Force Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // programOutputLabel
            // 
            this.programOutputLabel.AutoSize = true;
            this.programOutputLabel.Location = new System.Drawing.Point(12, 9);
            this.programOutputLabel.Name = "programOutputLabel";
            this.programOutputLabel.Size = new System.Drawing.Size(81, 13);
            this.programOutputLabel.TabIndex = 6;
            this.programOutputLabel.Text = "Program Output";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(401, 9);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(88, 13);
            this.databaseLabel.TabIndex = 7;
            this.databaseLabel.Text = "Database Output";
            // 
            // debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 612);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.programOutputLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "debug";
            this.Text = "Output";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.debug_FormClosing);
            this.Load += new System.EventHandler(this.debug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ElevatorDBDataSet elevatorDBDataSet;
        private System.Windows.Forms.BindingSource operationsLogBindingSource;
        private ElevatorDBDataSetTableAdapters.OperationsLogTableAdapter operationsLogTableAdapter;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liftPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label programOutputLabel;
        private System.Windows.Forms.Label databaseLabel;
    }
}