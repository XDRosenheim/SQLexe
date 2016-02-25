namespace SQLexe {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing ) {
      if(disposing && ( components != null )) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.serverBtnDisconnect = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.serverTxtDatabase = new System.Windows.Forms.TextBox();
      this.chkForceEncrypCon = new System.Windows.Forms.CheckBox();
      this.chkEncrypCon = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.consoleBox = new System.Windows.Forms.TextBox();
      this.serverNumPort = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.serverTxtPassword = new System.Windows.Forms.TextBox();
      this.serverTxtUsername = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.serverTxtIP = new System.Windows.Forms.TextBox();
      this.serverBtnClear = new System.Windows.Forms.Button();
      this.serverBtnConnect = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.databaseGroup = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.databaseTables = new System.Windows.Forms.ComboBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.serverNumPort)).BeginInit();
      this.databaseGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.serverBtnDisconnect);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.serverTxtDatabase);
      this.groupBox1.Controls.Add(this.chkForceEncrypCon);
      this.groupBox1.Controls.Add(this.chkEncrypCon);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.consoleBox);
      this.groupBox1.Controls.Add(this.serverNumPort);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.serverTxtPassword);
      this.groupBox1.Controls.Add(this.serverTxtUsername);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.serverTxtIP);
      this.groupBox1.Controls.Add(this.serverBtnClear);
      this.groupBox1.Controls.Add(this.serverBtnConnect);
      this.groupBox1.Location = new System.Drawing.Point(9, 9);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(256, 332);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Server";
      // 
      // serverBtnDisconnect
      // 
      this.serverBtnDisconnect.Location = new System.Drawing.Point(6, 172);
      this.serverBtnDisconnect.Name = "serverBtnDisconnect";
      this.serverBtnDisconnect.Size = new System.Drawing.Size(119, 23);
      this.serverBtnDisconnect.TabIndex = 8;
      this.serverBtnDisconnect.Text = "Disconnect";
      this.serverBtnDisconnect.UseVisualStyleBackColor = true;
      this.serverBtnDisconnect.Visible = false;
      this.serverBtnDisconnect.Click += new System.EventHandler(this.serverBtnDisconnect_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 74);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 13);
      this.label6.TabIndex = 99;
      this.label6.Text = "Database";
      // 
      // serverTxtDatabase
      // 
      this.serverTxtDatabase.Location = new System.Drawing.Point(65, 71);
      this.serverTxtDatabase.Name = "serverTxtDatabase";
      this.serverTxtDatabase.Size = new System.Drawing.Size(185, 20);
      this.serverTxtDatabase.TabIndex = 2;
      // 
      // chkForceEncrypCon
      // 
      this.chkForceEncrypCon.AutoSize = true;
      this.chkForceEncrypCon.Enabled = false;
      this.chkForceEncrypCon.Location = new System.Drawing.Point(131, 149);
      this.chkForceEncrypCon.Name = "chkForceEncrypCon";
      this.chkForceEncrypCon.Size = new System.Drawing.Size(106, 17);
      this.chkForceEncrypCon.TabIndex = 7;
      this.chkForceEncrypCon.Text = "Force Encryption";
      this.toolTip1.SetToolTip(this.chkForceEncrypCon, "SslMode=Required");
      this.chkForceEncrypCon.UseVisualStyleBackColor = true;
      // 
      // chkEncrypCon
      // 
      this.chkEncrypCon.AutoSize = true;
      this.chkEncrypCon.Location = new System.Drawing.Point(6, 149);
      this.chkEncrypCon.Name = "chkEncrypCon";
      this.chkEncrypCon.Size = new System.Drawing.Size(111, 17);
      this.chkEncrypCon.TabIndex = 6;
      this.chkEncrypCon.Text = "Enable encryption";
      this.toolTip1.SetToolTip(this.chkEncrypCon, "SslMode=Preferred");
      this.chkEncrypCon.UseVisualStyleBackColor = true;
      this.chkEncrypCon.CheckedChanged += new System.EventHandler(this.chkEncrypCon_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 198);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(45, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Console";
      // 
      // consoleBox
      // 
      this.consoleBox.Location = new System.Drawing.Point(6, 214);
      this.consoleBox.Multiline = true;
      this.consoleBox.Name = "consoleBox";
      this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.consoleBox.Size = new System.Drawing.Size(244, 112);
      this.consoleBox.TabIndex = 99;
      // 
      // serverNumPort
      // 
      this.serverNumPort.Location = new System.Drawing.Point(65, 45);
      this.serverNumPort.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
      this.serverNumPort.Name = "serverNumPort";
      this.serverNumPort.Size = new System.Drawing.Size(185, 20);
      this.serverNumPort.TabIndex = 1;
      this.serverNumPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 47);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(26, 13);
      this.label4.TabIndex = 99;
      this.label4.Text = "Port";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 126);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 99;
      this.label3.Text = "Password";
      // 
      // serverTxtPassword
      // 
      this.serverTxtPassword.Location = new System.Drawing.Point(65, 123);
      this.serverTxtPassword.Name = "serverTxtPassword";
      this.serverTxtPassword.PasswordChar = '•';
      this.serverTxtPassword.Size = new System.Drawing.Size(185, 20);
      this.serverTxtPassword.TabIndex = 5;
      this.toolTip1.SetToolTip(this.serverTxtPassword, "Password for the user.");
      // 
      // serverTxtUsername
      // 
      this.serverTxtUsername.Location = new System.Drawing.Point(65, 97);
      this.serverTxtUsername.Name = "serverTxtUsername";
      this.serverTxtUsername.Size = new System.Drawing.Size(185, 20);
      this.serverTxtUsername.TabIndex = 4;
      this.serverTxtUsername.Text = "root";
      this.toolTip1.SetToolTip(this.serverTxtUsername, "Username for the server.");
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 99;
      this.label2.Text = "User";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 99;
      this.label1.Text = "Server";
      // 
      // serverTxtIP
      // 
      this.serverTxtIP.Location = new System.Drawing.Point(65, 19);
      this.serverTxtIP.Name = "serverTxtIP";
      this.serverTxtIP.Size = new System.Drawing.Size(185, 20);
      this.serverTxtIP.TabIndex = 0;
      this.serverTxtIP.Text = "localhost";
      this.toolTip1.SetToolTip(this.serverTxtIP, "Enter the ip/domain to the server.");
      // 
      // serverBtnClear
      // 
      this.serverBtnClear.Location = new System.Drawing.Point(131, 172);
      this.serverBtnClear.Name = "serverBtnClear";
      this.serverBtnClear.Size = new System.Drawing.Size(119, 23);
      this.serverBtnClear.TabIndex = 9;
      this.serverBtnClear.Text = "Clear";
      this.serverBtnClear.UseVisualStyleBackColor = true;
      this.serverBtnClear.Click += new System.EventHandler(this.serverBtnClear_Click);
      // 
      // serverBtnConnect
      // 
      this.serverBtnConnect.Location = new System.Drawing.Point(6, 172);
      this.serverBtnConnect.Name = "serverBtnConnect";
      this.serverBtnConnect.Size = new System.Drawing.Size(119, 23);
      this.serverBtnConnect.TabIndex = 8;
      this.serverBtnConnect.Text = "Connect";
      this.serverBtnConnect.UseVisualStyleBackColor = true;
      this.serverBtnConnect.Click += new System.EventHandler(this.serverBtnConnect_Click);
      // 
      // databaseGroup
      // 
      this.databaseGroup.Controls.Add(this.label7);
      this.databaseGroup.Controls.Add(this.databaseTables);
      this.databaseGroup.Enabled = false;
      this.databaseGroup.Location = new System.Drawing.Point(269, 9);
      this.databaseGroup.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
      this.databaseGroup.Name = "databaseGroup";
      this.databaseGroup.Size = new System.Drawing.Size(256, 332);
      this.databaseGroup.TabIndex = 14;
      this.databaseGroup.TabStop = false;
      this.databaseGroup.Text = "Server";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 22);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(39, 13);
      this.label7.TabIndex = 100;
      this.label7.Text = "Tables";
      // 
      // databaseTables
      // 
      this.databaseTables.FormattingEnabled = true;
      this.databaseTables.Location = new System.Drawing.Point(51, 19);
      this.databaseTables.Name = "databaseTables";
      this.databaseTables.Size = new System.Drawing.Size(199, 21);
      this.databaseTables.TabIndex = 0;
      this.databaseTables.SelectedIndexChanged += new System.EventHandler(this.databaseTables_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 348);
      this.Controls.Add(this.databaseGroup);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "SQLexe";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.serverNumPort)).EndInit();
      this.databaseGroup.ResumeLayout(false);
      this.databaseGroup.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox serverTxtIP;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button serverBtnClear;
    private System.Windows.Forms.Button serverBtnConnect;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox serverTxtPassword;
    private System.Windows.Forms.TextBox serverTxtUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown serverNumPort;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox consoleBox;
    private System.Windows.Forms.GroupBox databaseGroup;
    private System.Windows.Forms.CheckBox chkForceEncrypCon;
    private System.Windows.Forms.CheckBox chkEncrypCon;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox serverTxtDatabase;
    private System.Windows.Forms.Button serverBtnDisconnect;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox databaseTables;
  }
}

