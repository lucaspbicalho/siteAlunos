using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Table : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
		
			Conector c = new Conector();
			c.open();
			MySqlDataReader datareader = c.doquery("select * from alunos");

			StringBuilder table = new StringBuilder();
			table.Append("<center>");
			table.Append("<h1>Alunos</h1>");			
			table.Append("<table border='1'>");
			table.Append("<tr><th>ID</th><th>NOME</th><th>IDADE</th><th>TELEFONE CONTATO</th><th>ENDEREÇO</th><th>DATA NASCIMENTO</th><th>CPF</th>");
			table.Append("</tr>");

			if (datareader.HasRows)
			{
				
				while (datareader.Read())
				{
					table.Append("<tr>");
					table.Append("<td>" + datareader[0]+ "</td>");
					table.Append("<td>" + datareader[1] + "</td>");
					table.Append("<td>" + datareader[2] + "</td>");
					table.Append("<td>" + datareader[3] + "</td>");
					table.Append("<td>" + datareader[4] + "</td>");
					table.Append("<td>" + datareader[5] + "</td>");
					table.Append("<td>" + datareader[6] + "</td>");
					table.Append("</tr>");

				}
			}
			table.Append("</table>");
			table.Append("</center>");
			PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

		}
	}
}