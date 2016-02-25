using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLexe {
  public partial class Form1 : Form {
    private MySqlConnection _con;
    public int Port;
    public IPAddress IpHost;
    public IPHostEntry Host;
    public string Database;

    public Form1() {
      InitializeComponent();
      Initialize();
    }
    private void Initialize() {
      Port = Convert.ToInt32( serverNumPort.Text );
    }

    private void serverBtnClear_Click( object sender, EventArgs e ) {
      consoleBox.Clear();
    }
    private void serverBtnConnect_Click( object sender, EventArgs e ) {
      Host = Dns.GetHostEntry( serverTxtIP.Text );
      IpHost = Host.AddressList[0];
      Port = Convert.ToInt32( serverNumPort.Text );
      Database = serverTxtDatabase.Text;
      
      var stringe = "Server=" + IpHost + ";Port=" + Port + ";";
      if(Database != "") {
        stringe = stringe + "Database=" + Database + ";";
      }
      stringe = stringe + "Uid=" + serverTxtUsername.Text + ";Pwd=" + serverTxtPassword.Text + ";";
      if(chkEncrypCon.Checked && chkForceEncrypCon.Checked) {
        stringe = stringe + "SslMode=Required;";
      } else if(chkEncrypCon.Checked && !chkForceEncrypCon.Checked) {
        stringe = stringe + "SslMode=Preferred;";
      }

      _con = new MySqlConnection( stringe );

      try {
        var sslConnectionVerify = new MySqlCommand( "show status like 'Ssl_cipher';", _con );
        _con.Open();
        consoleBox.AppendText( @"Successful connection to " + serverTxtIP.Text + " established." + Environment.NewLine );
        Enable( false );
        var reader = sslConnectionVerify.ExecuteReader();
        var isSsl = "";
        if(reader.HasRows) {
          while(reader.Read()) {
            isSsl = reader[1].ToString();
          }
        }
        if(chkEncrypCon.Checked) {
          consoleBox.AppendText( isSsl != "" ? @"Connection is encrypted." + Environment.NewLine : @"Connection is NOT encrypted." + Environment.NewLine );
        }
        _con.Close();
        QueryIt sql = new QueryIt();
        List<string> tables = sql.TablesList( _con, serverTxtDatabase.Text );

        foreach (var dims in tables) {
          databaseTables.Items.Add( dims );
        }
      } catch(MySqlException sqlException) {
        consoleBox.AppendText( @"Failed to connect to " + serverTxtIP.Text + Environment.NewLine + @"Error message: " + sqlException.Message + Environment.NewLine );
      }
    }
    private void chkEncrypCon_CheckedChanged( object sender, EventArgs e ) {
      chkForceEncrypCon.Enabled = chkEncrypCon.Checked;
      if(!chkEncrypCon.Checked) chkForceEncrypCon.Checked = false;
    }
    private void serverBtnDisconnect_Click( object sender, EventArgs e ) {
      Enable( true );
      _con.Dispose();
      consoleBox.AppendText( @"Disconnected from " + serverTxtIP.Text + Environment.NewLine );
    }
    private void Enable( bool enableThem ) {
      serverTxtDatabase.Enabled = enableThem;
      serverTxtIP.Enabled = enableThem;
      serverNumPort.Enabled = enableThem;
      serverTxtUsername.Enabled = enableThem;
      serverTxtPassword.Enabled = enableThem;
      serverBtnConnect.Enabled = enableThem;
      serverBtnConnect.Visible = enableThem;
      chkEncrypCon.Enabled = enableThem;
      chkForceEncrypCon.Enabled = enableThem;
      serverBtnDisconnect.Enabled = !enableThem;
      serverBtnDisconnect.Visible = !enableThem;
      databaseGroup.Enabled = !enableThem;
    }

    private void databaseTables_SelectedIndexChanged( object sender, EventArgs e ) {
      
    }
  }
}
