using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for aluno
/// </summary>
public class aluno
{
	private string nome = "";
	private int idade = 0;
	private Int64 telefone = 0;
	private string endereco = "";
	private DateTime dataNascimento;
	private Int64 cpf = 0;
	public aluno()
	{
		
	}
	public void atribuirDados(string nome,string idade,string telefone,string endereco,string dataNas,string cpf)
	{
		try
		{
			this.nome = nome;
			this.idade = Convert.ToInt32(idade);
			this.telefone = Convert.ToInt64(telefone);
			this.endereco = endereco;
			int dia = Convert.ToInt32(dataNas.Split('/')[0]);
			int mes = Convert.ToInt32(dataNas.Split('/')[1]);
			int ano = Convert.ToInt32(dataNas.Split('/')[2]);
			this.dataNascimento = new DateTime(ano, mes, dia);
			this.cpf = Convert.ToInt64(cpf);
		}
		catch (Exception)
		{

			throw new Exception("Nao foi possivel atribuir dados de aluno");
		}
	}
	public override string ToString()
	{
		//nome,idade,telefonecontato,endereco,datanasc,cpf
		return "'"+this.nome + "'," + this.idade.ToString() + "," + this.telefone.ToString() + ",'" + this.endereco + "','"
			+ this.dataNascimento.ToString("yyyy/MM/dd") + "'," + this.cpf.ToString();
	}

}