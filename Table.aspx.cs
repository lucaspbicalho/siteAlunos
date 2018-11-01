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
		if (!login.m_logado)
		{
			string currentURL = HttpContext.Current.Request.Url.AbsoluteUri;
			currentURL = currentURL.Substring(0, currentURL.LastIndexOf("/"));
			currentURL = currentURL + @"/naoLogado.html";
			Response.Redirect(currentURL);
		}
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
		int currentID=0;
		aluno aluno = new aluno();
		aluno.atribuirDados(this.TextAreaNOME.Value, this.TextAreaIDADE.Value, this.TextAreaTELEFONE.Value,
			this.TextAreaENDERECO.Value, this.TextAreaDATA.Value, this.TextAreaCPF.Value);
		
		Conector c = new Conector();
		c.open();
		MySqlDataReader datareader = c.doquery("select max(id) from alunos");
		if (datareader.HasRows)
		{
			while (datareader.Read())
			{
				 currentID = Convert.ToInt32(datareader[0]);
				currentID = currentID + 1;
			}
		}
		else
		{
			throw new Exception("erro ao pegar Maximo ID de alunos");
		}
		datareader.Close();
		datareader = c.doquery("insert into alunos (id,nome,idade,telefonecontato,endereco,datanasc,cpf)" +
			   " Values (" + currentID.ToString() + "," + aluno.ToString() + ")");

		if (datareader.RecordsAffected > 0)
		{
			Response.Write("<script>alert('Dados incluidos com Sucesso');</script>");
		}
		else
		{
			Response.Write("<script>alert('Os Dados não foram incluidos');</script>");
		}


	}
}