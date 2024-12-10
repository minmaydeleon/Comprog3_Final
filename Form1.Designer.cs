using System.Windows.Forms;

partial class MemberForm
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridView1;
    private Button btnAdd;
    private Button btnDelete;
    private Button btnUpdate;
    private Button btnGeneratePdf;
    private Button btnDeleteMembershipType;
    private ComboBox cmbMembershipType;
    private DateTimePicker dtpStartDate;
    private DateTimePicker dtpEndDate;
    private TextBox txtName;
    private Label lblName;
    private Label lblMembershipType;
    private Label lblStartDate;
    private Label lblEndDate;
    private Label lblNewMembershipType;
    private TextBox txtNewMembershipType;
    private Button btnAddNewMembershipType;

    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.btnDeleteMembershipType = new System.Windows.Forms.Button();
            this.cmbMembershipType = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblNewMembershipType = new System.Windows.Forms.Label();
            this.txtNewMembershipType = new System.Windows.Forms.TextBox();
            this.btnAddNewMembershipType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(553, 274);
            this.dataGridView1.TabIndex = 0;
           
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(269, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
           
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(16, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
          
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(167, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Member";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
           
            this.btnGeneratePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGeneratePdf.Location = new System.Drawing.Point(409, 509);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(156, 39);
            this.btnGeneratePdf.TabIndex = 4;
            this.btnGeneratePdf.Text = "Generate PDF";
            this.btnGeneratePdf.UseVisualStyleBackColor = false;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
           
            this.btnDeleteMembershipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteMembershipType.Location = new System.Drawing.Point(386, 56);
            this.btnDeleteMembershipType.Name = "btnDeleteMembershipType";
            this.btnDeleteMembershipType.Size = new System.Drawing.Size(200, 36);
            this.btnDeleteMembershipType.TabIndex = 5;
            this.btnDeleteMembershipType.Text = "Delete Membership Type";
            this.btnDeleteMembershipType.UseVisualStyleBackColor = false;
            this.btnDeleteMembershipType.Click += new System.EventHandler(this.btnDeleteMembershipType_Click);
         
            this.cmbMembershipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbMembershipType.FormattingEnabled = true;
            this.cmbMembershipType.Location = new System.Drawing.Point(156, 56);
            this.cmbMembershipType.Name = "cmbMembershipType";
            this.cmbMembershipType.Size = new System.Drawing.Size(224, 28);
            this.cmbMembershipType.TabIndex = 6;
          
            this.dtpStartDate.Location = new System.Drawing.Point(99, 106);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(305, 26);
            this.dtpStartDate.TabIndex = 7;
           
            this.dtpEndDate.Location = new System.Drawing.Point(99, 145);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(305, 26);
            this.dtpEndDate.TabIndex = 8;
            
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(62, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 26);
            this.txtName.TabIndex = 9;
          
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
          
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(12, 64);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(138, 20);
            this.lblMembershipType.TabIndex = 11;
            this.lblMembershipType.Text = "Membership Type:";
         
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 106);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(87, 20);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date:";
     
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(12, 145);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(81, 20);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "End Date:";
         
            this.lblNewMembershipType.AutoSize = true;
            this.lblNewMembershipType.Location = new System.Drawing.Point(12, 195);
            this.lblNewMembershipType.Name = "lblNewMembershipType";
            this.lblNewMembershipType.Size = new System.Drawing.Size(173, 20);
            this.lblNewMembershipType.TabIndex = 14;
            this.lblNewMembershipType.Text = "New Membership Type:";
         
            this.txtNewMembershipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNewMembershipType.Location = new System.Drawing.Point(181, 195);
            this.txtNewMembershipType.Name = "txtNewMembershipType";
            this.txtNewMembershipType.Size = new System.Drawing.Size(189, 26);
            this.txtNewMembershipType.TabIndex = 15;
     
            this.btnAddNewMembershipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNewMembershipType.Location = new System.Drawing.Point(376, 190);
            this.btnAddNewMembershipType.Name = "btnAddNewMembershipType";
            this.btnAddNewMembershipType.Size = new System.Drawing.Size(189, 37);
            this.btnAddNewMembershipType.TabIndex = 16;
            this.btnAddNewMembershipType.Text = "Add Membership Type";
            this.btnAddNewMembershipType.UseVisualStyleBackColor = false;
            this.btnAddNewMembershipType.Click += new System.EventHandler(this.btnAddNewMembershipType_Click);
           
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(590, 584);
            this.Controls.Add(this.btnAddNewMembershipType);
            this.Controls.Add(this.txtNewMembershipType);
            this.Controls.Add(this.lblNewMembershipType);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbMembershipType);
            this.Controls.Add(this.btnDeleteMembershipType);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MemberForm";
            this.Text = "Gym Membership System";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}
