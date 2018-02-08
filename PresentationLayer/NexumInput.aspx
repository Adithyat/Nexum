<%@ Page Title="" Language="C#" MasterPageFile="~/Nexum.Master" AutoEventWireup="true" CodeBehind="NexumInput.aspx.cs" Inherits="PresentationLayer.NexumHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link rel="stylesheet" href="Content/eyocssfinal.css" />--%>
    <link rel="stylesheet" href="Content/forms.css" />
    <link rel="stylesheet" href="Content/forms2.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
        <div class="signin">
        <h2 class="signintitle">New Person</h2>
        <section class="maincontent" role="main">

            <div class="bg-white">
                <table id="pedestal">
                    <tr>
                        <td>
                            <h2 class="section-subheading">Name:
                            </h2>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="Name" type="text" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h2 class="section-subheading">Phone:
                            </h2>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="Phone" type="number" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h2 class="section-subheading">Region:
                            </h2>
                        </td>
                        <td>
                            <asp:DropDownList ID="lstRegions" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GetCountries" style="width:250px;font-size: 14px;padding: 5px;margin: 0 0 0;background-color: #fff;color: #555;border: 1px solid #ccc;" ></asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h2 class="section-subheading">Country:
                            </h2>
                        </td>
                        <td>
                            <asp:DropDownList ID="lstCountries" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GetStates" style="width:250px;font-size: 14px;padding: 5px;margin: 0 0 0;background-color: #fff;color: #555;border: 1px solid #ccc;"></asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h2 class="section-subheading">State:
                            </h2>
                        </td>
                        <td>
                            <asp:DropDownList ID="lstStates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GetCities" style="width:250px;font-size: 14px;padding: 5px;margin: 0 0 0;background-color: #fff;color: #555;border: 1px solid #ccc;"></asp:DropDownList>

                        </td>
                    </tr>

                    <tr>
                        <td>
                            <h2 class="section-subheading">City:
                            </h2>
                        </td>
                        <td>
                            <asp:DropDownList ID="lstCities"  runat="server" AutoPostBack="True" style="width:250px;font-size: 14px;padding: 5px;margin: 0 0 0;background-color: #fff;color: #555;border: 1px solid #ccc;"></asp:DropDownList>
                        </td>
                    </tr>

                    <tr>

                        <td style="width: 50%;">
                            <div style="float: right; margin-right:3em;">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" class="signinbutton" />
                            </div>
                        </td>
                        <td style="width: 50%;">
                            <div style="float: left; margin-left:3em;">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="cancel" class="signinbutton" />
                            </div>
                        </td>

                    </tr>
                </table>
            </div>

        </section>
    </div>
    

</asp:Content>
