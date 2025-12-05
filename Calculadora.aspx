<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="disenodemarco">
            <h1>Calculadora</h1>
            <br />

            
            <asp:Label ID="lresultado" runat="server" Font-Size="XX-Large" CssClass="pantalla"></asp:Label>
            <br /><br />

            
            <div>
                <asp:Button ID="b1" CssClass="button button2" Text="1" runat="server" OnClick="b1_Click" />
                <asp:Button ID="b2" CssClass="button button2" Text="2" runat="server" OnClick="b2_Click" />
                <asp:Button ID="b3" CssClass="button button2" Text="3" runat="server" OnClick="b3_Click" />
                <br />

                <asp:Button ID="Button4" CssClass="button button2" Text="4" runat="server" OnClick="Button4_Click" />
                <asp:Button ID="Button5" CssClass="button button2" Text="5" runat="server" OnClick="Button5_Click" />
                <asp:Button ID="Button6" CssClass="button button2" Text="6" runat="server" OnClick="Button6_Click" />
                <br />

                <asp:Button ID="b7" CssClass="button button2" Text="7" runat="server" OnClick="b7_Click" />
                <asp:Button ID="b8" CssClass="button button2" Text="8" runat="server" OnClick="b8_Click" />
                <asp:Button ID="b9" CssClass="button button2" Text="9" runat="server" OnClick="b9_Click" />
                <br />

                <asp:Button ID="b0" CssClass="button button2" Text="0" runat="server" OnClick="b0_Click" />
            </div>

            <br />

            
            <div>
                <asp:Button ID="bsuma"  CssClass="button button3" Text="+" runat="server" OnClick="bsuma_Click" />
                <asp:Button ID="bresta" CssClass="button button3" Text="-" runat="server" OnClick="bresta_Click" />
                <asp:Button ID="bmulti" CssClass="button button3" Text="*" runat="server" OnClick="bmulti_Click" />
                <asp:Button ID="bdivi"  CssClass="button button3" Text="/" runat="server" OnClick="bdivi_Click" />
            </div>

            <br />

            
            <div>
                <asp:Button ID="bpot2" CssClass="button button3" Text="x²"  runat="server" OnClick="bpot2_Click" />
                <asp:Button ID="bpot3" CssClass="button button3" Text="x³"  runat="server" OnClick="bpot3_Click" />
                <asp:Button ID="braiz" CssClass="button button3" Text="√x"  runat="server" OnClick="braiz_Click" />
                <asp:Button ID="bfact" CssClass="button button3" Text="n!"  runat="server" OnClick="bfact_Click" />
                <asp:Button ID="bfib"  CssClass="button button3" Text="Fib" runat="server" OnClick="bfib_Click" />
            </div>

            <br />

            
            <div>
                <asp:Button ID="bresultado" CssClass="button button4" Text="=" runat="server" OnClick="bresultado_Click" />
                <asp:Button ID="bclear"     CssClass="button button5" Text="C" runat="server" OnClick="bclear_Click" />
            </div>

            
            <asp:Panel ID="PanelPOO" runat="server" Visible="false">

                <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>
                <asp:TextBox ID="tvalor1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
                <asp:TextBox ID="tvalor2" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="bcalcular" runat="server" Text="Calcular" OnClick="bcalcular_Click" />
                <br /><br />

                <div>
                    <asp:RadioButton ID="rsuma"  Text="Sumar" GroupName="op" runat="server" />
                    <asp:RadioButton ID="rresta" Text="Resta" GroupName="op" runat="server" />
                </div>

                <div>
                    <asp:CheckBox ID="Csuma"  Text="Sumar"  runat="server" />
                    <asp:CheckBox ID="Cresta" Text="Restar" runat="server" />
                </div>

                <div>
                    <asp:DropDownList ID="Dlista" runat="server">
                        <asp:ListItem>Suma</asp:ListItem>
                        <asp:ListItem>Resta</asp:ListItem>
                        <asp:ListItem>Multiplicacion</asp:ListItem>
                        <asp:ListItem>Division</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                        <asp:ListItem>Suma</asp:ListItem>
                        <asp:ListItem>Resta</asp:ListItem>
                        <asp:ListItem>Multiplicacion</asp:ListItem>
                        <asp:ListItem>Division</asp:ListItem>
                    </asp:ListBox>
                </div>

            </asp:Panel>

        </div>
    </form>
</body>
</html>
