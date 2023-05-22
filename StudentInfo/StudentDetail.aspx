<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetail.aspx.cs" Inherits="StudentInfo.StudentDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server">
                <Items>
                    <asp:MenuItem Text="StudentInfo" Value="StudentInfo" />
                     <asp:MenuItem Text="About" Value="About" />
                     <asp:MenuItem Text="Contact" Value="Contact" />
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
