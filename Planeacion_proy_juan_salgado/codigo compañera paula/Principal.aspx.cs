using System;
using System.Text;
using System.Security.Cryptography;


public partial class Vista_Principal : System.Web.UI.Page
{
	protected static StringBuilder sbMensaje = new StringBuilder();
	string Password = "123456";
	float Saldo;
	 
	protected void Page_Load(object sender, EventArgs e)
	{
		//Refresh
		if (!IsPostBack)
		{
			
			HDSaldo.Value = "1000000";
		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 0;
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		//Consulta Saldo Y Cobra 3000 Por Consulta
		if (TxtPass.Text == Password)
		{
			
			TxtPass.Text = generarClaveSHA1(TextBox4.Text);
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 3000).ToString();
			TxtSaldo.Text = HDSaldo.Value.ToString();
			MultiView1.ActiveViewIndex = 1;
		}
		
	}
	//Limpia Datos 
	protected void btnPasswd_Click(object sender, EventArgs e)
	{
		if (TxtPassRetiro.Text == Password)
		{
			LimpiarDatos();
		}
	}

	protected void Button4_Click(object sender, EventArgs e)
	{
		//Retiro Cuenta
		HDSaldo.Value = (float.Parse(HDSaldo.Value) - 10000).ToString();
		ImprimirMensaje("Retiro Exitoso");
		TxtPassRetiro.Text = HDSaldo.Value.ToString();
	}

	protected void Button5_Click(object sender, EventArgs e)
	{
		//Retiro Cuenta
		if (float.Parse(HDSaldo.Value) > 45000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 20000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else {
			ImprimirMensaje("Retiro No Exitoso");
		}
	}

	protected void Button6_Click(object sender, EventArgs e)
	{
		//Retiro Cuenta
		if (float.Parse(HDSaldo.Value) > 525000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 50000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else
		{
			ImprimirMensaje("Retiro No Exitoso");
		}
	}

		protected void Button2_Click(object sender, EventArgs e)
		{
			MultiView1.ActiveViewIndex = 2;
		}

		protected void Button11_Click(object sender, EventArgs e)
		{
		//No Permite Exceder El Monto Mas De 600000
			if (float.Parse(TextBox3.Text)>600000)
			{
				ImprimirMensaje("Ha Excedido El Monto Permitido");
				LimpiarDatos();
			}
		}


		protected void TextBox3_TextChanged(object sender, EventArgs e)
		{
		}
	//Imprimir Mensajes En Pantalla Emergente
	protected void ImprimirMensaje(string mensaje)
	{
		sbMensaje.Clear();
		sbMensaje.Append("<script type='text/javascript'>");
		sbMensaje.AppendFormat("alert('{0}');", mensaje);
		sbMensaje.Append("</script>");
		ClientScript.RegisterClientScriptBlock(this.GetType(), "mensaje", sbMensaje.ToString());
	}
	protected void LimpiarDatos()
	{
		TextBox3.Text = "";
		btnPasswd.Text = "";

	}
	
	//Método para generar una clave con un hash SHA-1, a partir de una cadena dada
    private string generarClaveSHA1(string cadena)
	{

		UTF8Encoding enc = new UTF8Encoding();
		byte[] data = enc.GetBytes(cadena);
		byte[] result;

		SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

	    result = sha.ComputeHash(data);


		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < result.Length; i++)
		{

			 //Convertimos los valores en hexadecimal
			 // cuando tiene una cifra hay que rellenarlo con cero
			 //para que siempre ocupen dos dígitos.
			if (result[i] < 16)
			{
				sb.Append("0");
			}
			sb.Append(result[i].ToString("x"));
		}

		//Devolvemos la cadena con el hash en mayúsculas.
		return sb.ToString().ToUpper();
	}


	protected void Button7_Click(object sender, EventArgs e)
	{
		//Retiro De Cuenta
		if (float.Parse(HDSaldo.Value) > 125000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 100000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else
		{
			ImprimirMensaje("Retiro No Exitoso");
		}

	}

	protected void Button8_Click(object sender, EventArgs e)
	{
		//Retiro De Cuenta
		if (float.Parse(HDSaldo.Value) > 225000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 200000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else
		{
			ImprimirMensaje("Retiro No Exitoso");
		}
	}

	protected void Button9_Click(object sender, EventArgs e)
	{
		//Retiro De Cuenta
		if (float.Parse(HDSaldo.Value) > 425000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 400000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else
		{

		}
	}

	protected void Button10_Click(object sender, EventArgs e)
	{
		//Retiro De Cuenta
		if (float.Parse(HDSaldo.Value) > 425000)
		{
			HDSaldo.Value = (float.Parse(HDSaldo.Value) - 600000).ToString();
			ImprimirMensaje("Retiro Exitoso");
			TxtPassRetiro.Text = HDSaldo.Value.ToString();
		}
		else
		{
			ImprimirMensaje("Retiro No Exitoso");
		}
	}
}
