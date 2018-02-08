<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="PresentationLayer.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/style.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="Content/eyocssfinal.css" />
    <link rel="stylesheet" href="Content/forms.css" />
    <link rel="stylesheet" href="Content/forms2.css" /> 
</head>
<body class="loginscreen">
    <div class="page">
        <nav id="mainnav">
            <ul id="nav">
                <li class="navtopic nav-home"> <a id="navHome" href="Webform">Home</a></li>
                <li class="navtopic nav-issues"> <a id="navIssues" href="/gl/en/issues">View</a></li>
                <li class="navtopic nav-industries"> <a id="navIndustries" href="/gl/en/industries">Insert</a></li>
            </ul>
        </nav>  
        <div class="page-container"> 
                <header id="header">
                    <div class="eylogo">
                        <a href="Webform"><img src="Content/EY.gif" alt="EY Ernst Young logo" border="0"/></a>
                    </div>
                </header>
                <div class="wrapper signinCP">
                    <div class="signin">
                        <h2 class="signintitle">New Person</h2>
                        <section class="maincontent" role="main">
                            <form id="form1" runat="server" >
                            <div class="bg-white">
                                <table id="pedestal">
                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                1. Name:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:Textbox runat="server" id="Name" type="text" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                2. Phone:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:Textbox runat="server" id="Phone" type="text" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                3. Region:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:DropDownList runat="server" id="Textbox1" type="text" />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                4. Country:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="lstCountries" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GetRegions" ></asp:DropDownList>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                5. State:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="lstStates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GetCities"></asp:DropDownList>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h2 class="section-subheading">
                                                6. City:
                                            </h2>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="lstCities" runat="server"></asp:DropDownList>
                                        </td>
                                    </tr>
                
                                    <tr>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="submit" class="signinbutton"/>
                                        </td>
                                        <td> 
                                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="cancel" class="signinbutton"/>
                                        </td>
                                    </tr>
                                </table>
                         </div>   
                    </form>
                        </section>
                    </div>
                </div>
        </div>
    </div>
</body>
</html>
