<%@ Page Title="" Language="C#" MasterPageFile="~/Nexum.Master" AutoEventWireup="true" CodeBehind="NexumView.aspx.cs" Inherits="PresentationLayer.NexumView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Content/master.css" />
    <link rel="stylesheet" href="Content/forms.css" />
    <script type="text/javascript" id="js_open">
        function OpenWindow(personId) {
            newwindow = window.open("DataDisplay.aspx?personID=" + personId, 'height=200,width=150');
            if (window.focus) { newwindow.focus() }
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
        <div>
        <table>
            <tr>
                <td class="auto-style1">
                    <label for="regDropDown" id="reg_lbl">Region </label>
                    <asp:DropDownList ID="regDD" runat="server" AutoPostBack="true" Width-="250px" OnSelectedIndexChanged="RegDD_OnSelectedIndexChange" />
                </td>



                <td class="auto-style1">
                    <label for="ctryDD" id="country_lbl">Country </label>
                    <asp:DropDownList ID="ctryDD" runat="server" AutoPostBack="true" Width-="250px" OnSelectedIndexChanged="CtryDD_OnSelectedIndexChange" />
                </td>



                <td class="auto-style1">
                    <label for="stateDD" id="state_lbl">State </label>
                    <asp:DropDownList ID="stateDD" runat="server" AutoPostBack="true" Width-="250px"  OnSelectedIndexChanged="StateDD_SelectedIndexChanged"/>
                </td>

                <td class="auto-style1">
                    <label for="cityDD" id="city_lbl">City </label>
                    <asp:DropDownList ID="cityDD" runat="server" Width-="250px" />
                </td>


                <td>
                    <div style="display: inline-block">
                        <%--<input name="uscLogon$btnSubmit" type="submit" id="uscLogon_btnSubmit" title="Sign In" value="Submit" class="signinbutton"> I want a button--%>
                        <asp:Button ID="filter_button" Text="Filter" CssClass="signinbutton" runat="server" OnClick="Filter_Click" />
                        <div>
                        </div>
                    </div>
                    

                </td>
                <td>
                    <div style="display: inline-block">
                        &nbsp;
                    </div>
                </td>
                <td>
                    <div style="display: inline-block">
                        <%--<input name="uscLogon$btnSubmit" type="submit" id="uscLogon_btnCancel" title="Sign In" value="Cancel" class="signinbutton"> I want a button--%>
                        <asp:Button ID="clear_button" Text="Clear" CssClass="signinbutton" runat="server" OnClick="Clear_Click" />



                    </div>
                </td>
                <td>
                    <div style="display: inline-block">
                        &nbsp;
                    </div>
                </td>
                <td>
                    <div style="display: inline-block">
                        <%--<input name="uscLogon$btnSubmit" type="submit" id="uscLogon_btnCancel" title="Sign In" value="Cancel" class="signinbutton"> I want a button--%>
                        <asp:Button ID="delete_button" Text="Delete" CssClass="signinbutton" runat="server" OnClick="delete_button_Click"/>



                    </div>
                </td>
            </tr>
        </table>
    </div>
    
                    <%--<table>
                        <tr>
                            <td class="auto-style1">
                                <label for="regDropDown" id="reg_lbl">Region </label>
                                <asp:DropDownList ID="regDD" runat="server" AutoPostBack="true" Width-="250px" OnSelectedIndexChanged="regDD_OnSelectedIndexChange" />
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <label for="ctryDD" id="country_lbl">Country </label>
                                <asp:DropDownList ID="ctryDD" runat="server" AutoPostBack="true" Width-="250px" OnSelectedIndexChanged="ctryDD_OnSelectedIndexChange" />
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <label for="stateDD" id="state_lbl">State </label>
                                <asp:DropDownList ID="stateDD" runat="server" Width-="250px" />
                            </td>

                        </tr>
                    </table>
                --%>
           
                <asp:GridView ID="GridView1" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical"
                    CssClass="ViewGrid" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="LightGray" Font-Bold="True" ForeColor="Black" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                    <Columns>
                        <asp:TemplateField HeaderText="Select" HeaderStyle-Width="10%" ItemStyle-Width="10%">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkProduct" runat="server" OnCheckedChanged="chkProduct_CheckedChanged" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PersonID" ItemStyle-Width="10%" HeaderStyle-Width="10%" HeaderText="Person ID" />
                        <asp:TemplateField HeaderText="Person Name" ItemStyle-Width="20%" HeaderStyle-Width="20%">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkbtn" Text='<%#Eval("PersonName")%>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>
            

        
</asp:Content>
