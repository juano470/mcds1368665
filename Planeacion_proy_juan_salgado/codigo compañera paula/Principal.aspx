<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Vista_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 100%;
		}
		.auto-style2 {
			width: 299px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<table class="auto-style1">
			<tr>
				<td class="auto-style2">
					<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Blue" Text="Cajero Automático"></asp:Label>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td>
					<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar Saldo" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Retiros" />
				</td>
				<td>
					<asp:HiddenField ID="HDSaldo" runat="server" />
				</td>
			</tr>
		</table>
		<asp:MultiView ID="MultiView1" runat="server">
			<asp:View ID="View1" runat="server">
				Ingrese Su Contraseña<br />
				<asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>
				&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:Button ID="btnEntrar" runat="server" OnClick="Button3_Click" Text="Ingresar" />
				&nbsp;
				<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
			</asp:View>
			<asp:View ID="View2" runat="server">
				Su Saldo Es:<br />
				<asp:TextBox ID="TxtSaldo" runat="server"></asp:TextBox>
				&nbsp;
			</asp:View>
			<asp:View ID="View3" runat="server">
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<table style="width:100%;">
					<tr>
						<td>
							<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="10.000" />
						</td>
						<td>
							<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="100.000" />
						</td>
						<td>
							<asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="600.000" />
						</td>
					</tr>
					<tr>
						<td>
							<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="height: 26px" Text="20.000" />
						</td>
						<td>
							<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="200.000" />
						</td>
						<td>Otro Valor:
							<pre style="padding: 5px; margin: 0px; font-style: normal; font-weight: normal; overflow: auto; word-wrap: normal; font-family: Consolas, Courier, monospace !important; color: rgb(0, 0, 0); font-size: 13px; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;"><asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox> <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Retirar" /></pre>
						</td>
					</tr>
					<tr>
						<td>
							<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="50.000" />
						</td>
						<td>
							<asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="400.000" />
						</td>
						<td>&nbsp;Saldo Actual:<br />
							<asp:TextBox ID="TxtPassRetiro" runat="server"></asp:TextBox>
							&nbsp;<asp:Button ID="btnPasswd" runat="server" OnClick="btnPasswd_Click" Text="Limpiar" />
						</td>
					</tr>
				</table>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			</asp:View>
		</asp:MultiView>
    
    </div>
    </form>
</body>
</html>
