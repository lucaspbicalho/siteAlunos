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
	private string m_tabela = "";
	protected void Page_Load(object sender, EventArgs e)
	{
		
	}

	protected void Button1_Click(object sender, EventArgs e)
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
				table.Append("<td>" + datareader[0] + "</td>");
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
		m_tabela = table.ToString();
		PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });


	}
	protected void Button2_Click(object sender, EventArgs e)
	{

		//INSERT INTO table_name(column1, column2, column3, ...)
		//VALUES(value1, value2, value3, ...);

		string nome = this.TextAreaNOME.Value;
		int idade = Convert.ToInt32(this.TextAreaIDADE.Value);
		Int64 telefone = Convert.ToInt64(this.TextAreaTELEFONE.Value);
		string endereco = this.TextAreaENDERECO.Value;
		string dataNascimento = this.TextAreaDATA.Value;
		Int64 cpf = Convert.ToInt64(this.TextAreaCPF.Value);

		Conector c = new Conector();
		c.open();
		MySqlDataReader datareader = c.doquery("insert into alunos (id,nome,idade,telefonecontato,endereco,datanasc,cpf)" +  
			" Values (a,s,x,c,v)");
		if (datareader.HasRows)
		{

		}
		else
		{

		}
}