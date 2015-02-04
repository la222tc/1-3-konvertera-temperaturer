<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_3_konvertera_temperaturer.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Konvertera temperaturer</h1>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Fel inträffade. Åtgärda felen och försök igen."/>

        <%-- Starttemperatur --%>
        <asp:Label ID="StartTempLabel" runat="server" Text="Starttemperatur:"></asp:Label>
        <asp:TextBox ID="StartTempTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="StartTempRequiredFieldValidator" runat="server" Text="*" 
            ErrorMessage="Ange en Starttemperatur" Display="Dynamic" ControlToValidate="StartTempTextBox"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="StartTempCompareValidator" runat="server" Text="*" ErrorMessage="Endast heltal är tillåtet" 
            ControlToValidate="StartTempTextBox" Display="Dynamic" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
   
    </div>

        <%-- Sluttemperatur --%>
        <div>
            <asp:Label ID="EndTempLabel" runat="server" Text="Sluttemperatur:"></asp:Label>
            <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="EndTempRequiredFieldValidator" runat="server" Text="*" 
                ErrorMessage="Ange en Sluttemperatur" Display="Dynamic" ControlToValidate="EndTempTextBox"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="EndTempCompareValidator" runat="server" 
                Text="*" ErrorMessage="Sluttemperaturen måste vara högre än Starttemperaturen"  
                Display="Dynamic" Type="Integer" Operator="GreaterThanEqual" ControlToCompare="StartTempTextBox" 
                ControlToValidate="EndTempTextBox"></asp:CompareValidator>
     
        </div>

                <%-- Temperatursteg --%>
        <div>
            <asp:Label ID="TemperaturstegLabel" runat="server" Text="Temperatursteg:"></asp:Label>
            <asp:TextBox ID="TemperaturstegTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="TemperaturstegRequiredFieldValidator" runat="server" Text="*" 
                ErrorMessage="Ange ett Temperatursteg" Display="Dynamic" ControlToValidate="TemperaturstegTextBox"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="TemperaturstegRangeValidator" runat="server" Text="*" 
                ErrorMessage="Temperatursteg måste ligga mellan 1 och 100" MinimumValue="1" MaximumValue="100" 
                ControlToValidate="TemperaturstegTextBox" Type="Integer"></asp:RangeValidator>

        </div>

                <%-- Typ av konvertering, raidoknappar --%>
        <div>   
            <h3>Typ av konvertering</h3>
            <asp:RadioButton ID="CelsiusToFahrnheit" runat="server" Checked="true" GroupName="Radio"/>
            <asp:Label ID="CelsiusToFahrnheitLabel" runat="server" Text="Celsius till Fahrnheit"></asp:Label>

            <asp:RadioButton ID="FahrnheitToCelsius" runat="server" GroupName="Radio"/>
            <asp:Label ID="FahrnheitToCelsiusLabel" runat="server" Text="Fahrnheit till Celsius"></asp:Label>
            <asp:Button ID="ConvertButton" runat="server" Text="Konvertera" OnClick="ConvertButton_Click" />
        </div>

         <%-- Resultat --%>
        <asp:Table ID="TemperatureTable" runat="server" Visible="false">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell ID="FirstTableHeaderCell">°C</asp:TableHeaderCell>
                <asp:TableHeaderCell ID="SecondTableHeaderCell">°F</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>

    </form>
</body>
</html>
