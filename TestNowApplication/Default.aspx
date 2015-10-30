<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmptyWebApplication.Default" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="Test.js"></script>
    <title>Test Jquery</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="clickClass" id="clickId">
            <p>If you click on me, I will disappear.</p>
            <p>Click me away!</p>
            <p>Click me too!</p>
        </div>

        <%--        <div>
            <asp:Label runat="server" ID="testLbl" Text="<%$ Resources:WebResources,PageResource1.Lable1%>""<%$ Resources:Lable1%>"></asp:Label>
            <asp:Button runat="server" ID="btnTestResource" Text="<%$ Resources:WebResources,PageResource1.Button1%>" OnClick="btnTestResource_Click" />
        </div>--%>

        <div>
            <div class="dropdown-menu">
                <div class="menu-title">Menu one</div>
                <div class="menu-items" style="display: none">
                    <div><a href="#">Item one</a></div>
                    <div><a href="#">Item two</a></div>
                </div>
            </div>
            <div class="dropdown-menu">
                <div class="menu-title">Menu Two</div>
                <div class="menu-items" style="display: none">
                    <div><a href="#">Item three</a></div>
                    <div><a href="#">Item four</a></div>
                </div>
            </div>

            <div>
               <%-- <asp:GridView ID="gvModels" runat="server"
                    OnRowDataBound="gvModels_RowDataBound"
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Model" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>--%>
            </div>

        </div>

    </form>
</body>
</html>
