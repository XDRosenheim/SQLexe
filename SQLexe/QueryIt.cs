using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SQLexe {
  class QueryIt {
    public List<string> TablesList( MySqlConnection con, string database ) {
      MySqlCommand cmd = new MySqlCommand( "SHOW TABLES IN " + database, con );
      con.Open();
      var reader = cmd.ExecuteReader();
      var returnMe = new List<string>();
      if(reader.HasRows) {
        while(reader.Read()) {
          returnMe.Add( reader[0].ToString() );
        }
      }
      return returnMe;
    }
  }
}
